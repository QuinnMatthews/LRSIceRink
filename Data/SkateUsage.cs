namespace LRSIceRink.Data {
    public class SkateUsage {
        public Guid Id { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime? TimeIn  { get; set; }

        public Guid? SkateId { get; set; }
        public virtual Skate? Skate { get; set; }
    }
}
