namespace MK.Funbeat
{
    public class RawTraining : Bindable
    {
        public int Id { get; set; }
        public string Data { get; set; }

        public bool HasData
        {
            get { return !string.IsNullOrWhiteSpace(Data); }
        }
    }
}