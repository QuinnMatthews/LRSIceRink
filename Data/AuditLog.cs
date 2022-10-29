namespace LRSIceRink.Data {
    public class AuditLog {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public ApplicationUser? User { get; set; }
        public Skate? Skate { get; set; }
        public string Action { get; set; }
    }
}
