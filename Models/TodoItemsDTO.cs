namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Detail { get; set; }
        public Priority Priority { get; set; }
        public bool IsComplete { get; set; }
    }
}