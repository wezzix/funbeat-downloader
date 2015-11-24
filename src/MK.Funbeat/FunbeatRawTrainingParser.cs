using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MK.Funbeat
{
    public class FunbeatRawTrainingParser
    {
        public IList<Training> ParseTrainings(IEnumerable<RawTraining> rawTrainings)
        {
            return rawTrainings.Select(ParseTraining).ToList();
        }

        public Training ParseTraining(RawTraining rawTraining)
        {
            return JsonConvert.DeserializeObject<Training>(rawTraining.Data);
        }
    }
}