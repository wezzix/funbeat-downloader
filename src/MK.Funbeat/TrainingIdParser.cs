using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace MK.Funbeat
{
    public class TrainingIdParser
    {
        public List<int> ParseTraining(HtmlNodeCollection calendarTable)
        {
            var trainingIds = calendarTable.Descendants("a")
                .Where(n => n.GetAttributeValue("href", "").Contains("TrainingID="))
                .Select(n => GetTrainingIdFromUrl(n.GetAttributeValue("href", "")))
                .Distinct()
                .ToList();
            return trainingIds;
        }

        private int GetTrainingIdFromUrl(string href)
        {
            return int.Parse(GetTrainingIdStringFromUrl(href));
        }

        private static string GetTrainingIdStringFromUrl(string href)
        {
            return Regex.Match(href, @"TrainingID=(\d+)").Groups[1].Value;
        }
    }
}