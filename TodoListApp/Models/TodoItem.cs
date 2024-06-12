namespace TodoListApp.Models
{
    public class TodoItem
    {
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateEdited { get; set; }
    }
}
