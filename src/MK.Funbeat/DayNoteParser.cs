using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using HtmlAgilityPack;
using MK.Funbeat.Utilities;

namespace MK.Funbeat
{
    public class DayNoteParser
    {
        public List<DayNote> ParseDayNotes(HtmlNodeCollection calendarTable)
        {
            var dayNoteDivs = GetDayNoteDivs(calendarTable);
            var dayNotes = ParseDayNoteDivs(dayNoteDivs);
            return dayNotes;
        }

        private static List<HtmlNode> GetDayNoteDivs(HtmlNodeCollection calendarTable)
        {
            return calendarTable.Descendants("div")
                .WithClassEqualTo("b-calendar-daynote")
                .ToList();
        }

        private List<DayNote> ParseDayNoteDivs(List<HtmlNode> dayNoteDivs)
        {
            var dayNotes = dayNoteDivs.Select(ParseDayNoteDiv).ToList();
            return dayNotes;
        }

        private DayNote ParseDayNoteDiv(HtmlNode dayNoteDiv)
        {
            var dayNote = new DayNote();

            ApplyDate(dayNoteDiv, dayNote);
            ApplyComment(dayNoteDiv, dayNote);
            ApplyNumbers(dayNoteDiv, dayNote);

            return dayNote;
        }

        private static void ApplyDate(HtmlNode dayNoteDiv, DayNote dayNote)
        {
            var dateLink = dayNoteDiv.FirstParent(n => n.Name == "table").Descendants("a").First();
            var match = Regex.Match(dateLink.GetAttributeValue("href", ""), @"StartDateTime=(\d{4}-\d\d-\d\d)");
            dayNote.Date = DateTime.Parse(match.Groups[1].Value);
        }

        private static void ApplyComment(HtmlNode dayNoteDiv, DayNote dayNote)
        {
            var commentNode = dayNoteDiv.Element("span");
            dayNote.Comment = commentNode != null
                ? HttpUtility.HtmlDecode(commentNode.InnerText)
                : null;
        }

        private void ApplyNumbers(HtmlNode dayNoteDiv, DayNote dayNote)
        {
            var dayNoteNumbersNode = dayNoteDiv.Descendants()
                .WithClassEqualTo("b-calendar-daynote-numbers")
                .SingleOrDefault();
            if (dayNoteNumbersNode != null)
            {
                var dayNoteLines =
                    dayNoteNumbersNode.ChildNodes.Where(o => o.NodeType == HtmlNodeType.Text)
                        .Select(o => o.InnerText)
                        .ToList();

                dayNoteLines.ForEach(s => ApplyDayNoteNumberLine(dayNote, s));
            }
        }

        private void ApplyDayNoteNumberLine(DayNote dayNote, string line)
        {
            ParseWeight(dayNote, line);
            ParseRestingHeartRate(dayNote, line);
            ParseCalories(dayNote, line);
        }

        private static void ParseWeight(DayNote dayNote, string line)
        {
            var match = Regex.Match(line, @"Vikt[:\s]*(\d+(?:[,\.]\d)?)");
            if (match.Success)
                dayNote.Weight = NumberParser.TryParseDecimal(match.Groups[1].Value);
        }

        private static void ParseRestingHeartRate(DayNote dayNote, string line)
        {
            var match = Regex.Match(line, @"Vilopuls[:\s]*(\d+)");
            if (match.Success)
                dayNote.RestingHeartRate = NumberParser.TryParseInt(match.Groups[1].Value);
        }

        private static void ParseCalories(DayNote dayNote, string line)
        {
            var match = Regex.Match(line, @"kcal[:\s]*(\d+)");
            if (match.Success)
                dayNote.KCal = NumberParser.TryParseInt(match.Groups[1].Value);
        }
    }
}