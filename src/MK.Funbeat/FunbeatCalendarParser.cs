using System.Collections.Generic;
using HtmlAgilityPack;

namespace MK.Funbeat
{
    public class FunbeatCalendarParser
    {
        private readonly DayNoteParser _dayNoteParser = new DayNoteParser();
        private readonly TrainingIdParser _trainingIdParser = new TrainingIdParser();

        public List<DayNote> ParseDayNotesFromCalendarSource(string html)
        {
            var calendarTable = GetCalendarTable(html);
            if (calendarTable == null)
                return new List<DayNote>();

            var dayNotes = _dayNoteParser.ParseDayNotes(calendarTable);
            return dayNotes;
        }

        public List<int> ParseTrainingIdsFromCalendarSource(string html)
        {
            var calendarTable = GetCalendarTable(html);
            if (calendarTable == null)
                return new List<int>();

            var trainingIds = _trainingIdParser.ParseTraining(calendarTable);
            return trainingIds;
        }

        private static HtmlNodeCollection GetCalendarTable(string html)
        {
            var document = new HtmlDocument();
            document.LoadHtml(html);
            var calendarTable = GetCalendarNode(document);
            return calendarTable;
        }

        private static HtmlNodeCollection GetCalendarNode(HtmlDocument document)
        {
            return document.DocumentNode.SelectNodes("//div[@class='b-calendar-frame']/table[@class='calendar']");
        }
    }
}