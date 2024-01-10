namespace TaskManagementApp.API.Domain.Tasks
{
    public class ChecklistItem
    {
        public int ChecklistItemID { get; set; }
        public string Text { get; set; }
        public bool Complete { get; set; } = false;
        public AppTask ParentTask { get; set; }
    }
}
