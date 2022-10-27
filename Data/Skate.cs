namespace LRSIceRink.Data {
    public enum SkateStatus {
        Available,
        InUse,
        BeingSharpened
    };
    public class Skate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public SkateStatus Status { get; set; }
    }
}
