using System;

namespace MK.Funbeat
{
    public class DayNote : Bindable
    {
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public decimal? Weight { get; set; }
        public int? RestingHeartRate { get; set; }
        public int? KCal { get; set; }

        #region Equality

        protected bool Equals(DayNote other)
        {
            return Date.Equals(other.Date);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            var other = obj as DayNote;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            return Date.GetHashCode();
        }

        public static bool operator ==(DayNote left, DayNote right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DayNote left, DayNote right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}