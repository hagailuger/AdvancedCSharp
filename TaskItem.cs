    public sealed class TaskItem
   {
       public int Id { get; }
       public string Title { get; private set; }
       public DateTime? DueDate { get; private set; }
       public bool IsDone { get; private set; }

       public TaskItem(int id, string title)
       {
           Id = id;
           Title = title;
       }

       public TaskItem(int id, string title, DateTime dueDate) : this(id, title)
       {
           DueDate = dueDate;
       }

       public void MarkDone() => IsDone = true;

       public void Rename(string newTitle)
       {
           Title = newTitle;
       }

       public override string ToString()
       {
           var mark = IsDone ? "V" : "X";
           var due = DueDate.HasValue ? $" (Due: {DueDate:dd/MM/yyyy})" : string.Empty;
           return $"#{Id}: {Title}{due} {mark}";
       }
   }
