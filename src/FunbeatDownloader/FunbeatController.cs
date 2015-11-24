using System.ComponentModel;
using System.Linq;
using MK.Funbeat;

namespace FunbeatDownloader
{
    public class FunbeatController : Bindable
    {
        public FunbeatController()
        {
            DayNotes = new BindingList<DayNote>();
            RawTrainings = new BindingList<RawTraining>();
            Trainings = new BindingList<Training>();
        }

        public BindingList<DayNote> DayNotes { get; private set; }
        public BindingList<RawTraining> RawTrainings { get; private set; }
        public BindingList<Training> Trainings { get; private set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CanFetchTrainings
        {
            get { return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password); }
        }

        private bool CanConvertRawTrainings
        {
            get { return RawTrainings.Count > 0; }
        }

        public void ParseCalendarSource(string html)
        {
            ParseDayNotes(html);

            ParseTrainingRawDatas(html);
        }

        public void FetchTrainings()
        {
            if (!CanFetchTrainings)
                return;
            try
            {
                new FunbeatTrainingScraper().ScrapeTrainings(
                    RawTrainings.Where(o => !o.HasData), GetAuthenticationParameters());
            }
            catch
            {
                // Silent fail. User may try again.
            }
            ConvertRawTrainingData();
        }

        private void ConvertRawTrainingData()
        {
            if (!CanConvertRawTrainings)
                return;
            var trainings = new FunbeatRawTrainingParser().ParseTrainings(RawTrainings.Where(o => o.HasData));
            Trainings.Clear();
            trainings.ToList().ForEach(Trainings.Add);
        }

        private void ParseDayNotes(string html)
        {
            var dayNotes = new FunbeatCalendarParser().ParseDayNotesFromCalendarSource(html);
            var newDayNotes = dayNotes.Where(dn => !DayNotes.Contains(dn)).ToList();
            newDayNotes.ForEach(DayNotes.Add);
        }

        private void ParseTrainingRawDatas(string html)
        {
            var trainingIds = new FunbeatCalendarParser().ParseTrainingIdsFromCalendarSource(html);
            var newTrainingRawDatas = trainingIds
                .Where(id => RawTrainings.All(existing => existing.Id != id))
                .Select(id => new RawTraining { Id = id })
                .ToList();
            newTrainingRawDatas.ForEach(RawTrainings.Add);
        }

        private AuthenticationParameters GetAuthenticationParameters()
        {
            return new AuthenticationParameters
            {
                Username = Username,
                Password = Password,
            };
        }
    }
}