namespace TodoApi.Models
{
    public enum Priority
    {
        LOW,
        MED,
        HIGH
    }
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Detail { get; set; }
        public Priority Priority { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
}