namespace LRSIceRink.Data {
    public enum SkateStatus {
        Available,
        InUse,
        BeingSharpened
    };
    public class Skate: IComparable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SkateStatus Status { get; set; }
        public double MinutesUsed { get; set; }
        public bool IsArchived { get; set; }
        public virtual List<SkateUsage> SkateUsages { get; set; }
        public virtual List<AuditLog> SkateHistory { get; set; }
        public void addMinutesUsed(double minutes)
        {
            MinutesUsed += minutes;
        }

        public int CompareTo(object incomingobject) {
            Skate incomingskate = incomingobject as Skate;

            return this.Id.CompareTo(incomingskate.Id);
        }
    }
}
