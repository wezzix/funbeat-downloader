using System;
using Newtonsoft.Json;

namespace MK.Funbeat
{
    public class Training : Bindable
    {
        public int TrainingID { get; set; }
        public DateTime StartDateTime { get; set; }
        public string TrainingTypeName { get; set; }

        [JsonConverter(typeof(FunbeatDurationConverter))]
        public TimeSpan Duration { get; set; }

        public decimal? Distance { get; set; }
        public int? Ascent { get; set; }
        public int? Descent { get; set; }
        public string Description { get; set; }
        public string PrivateComment { get; set; }
        public int? Intensity { get; set; }
        public int? CadAvg { get; set; }
        public int? HRAvg { get; set; }
        public int? HRMax { get; set; }
        public int? EffectAvg { get; set; }
        public int? EffectMax { get; set; }
        // IntervalsAndLaps
        public int? KCal { get; set; }
        public string RouteName { get; set; }
        public int? Sets { get; set; }
        public int? Repetitions { get; set; }
        public int? Steps { get; set; }
        public decimal? TE { get; set; }
        public decimal? Weight { get; set; }
        public bool HasTimeOfDay { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string[] Photos { get; set; }
        public string[] Equipment { get; set; }
        public bool isCompetition { get; set; }
        public string RaceTitle { get; set; }
        public string RouteID { get; set; }
        public int TrainingTypeID { get; set; }
        // Exercises
        public string GeoRegionID { get; set; }
    }
}