namespace MyEx
{
	class Program
    {
        static void Main(string[] args)
        {
			var board = new TaskBoard(capacity: 5);

			var t1 = new TaskItem(1, "Buy milk", DateTime.Today.AddDays(1));
			var t2 = new TaskItem(2, "Send report", DateTime.Today.AddDays(5));
			var t3 = new TaskItem(3, "Call supplier");
			
			board.Add(t1);
			board.Add(t2);
			var isSuccess = board.Add(t3);
			if (!isSuccess)
			{
			    Console.WriteLine("failed to add item");
			}
			
			Console.WriteLine($"{board.Count} items");
			
			var firstItem = board.FindById(1);
			firstItem.Rename("buy bread");
			
			var secondItem = board.FindById(2);
			
			if (secondItem != null)
			{
			    secondItem.MarkDone();
			}
			
			Console.WriteLine("=== All Tasks ===");
			board.PrintAll();
			
			board.PrintPendingSummary();

				/*	
						3 items
						  === All Tasks ===
						#1: Buy milk (Due: 28/08/2025) X
						#2: Send report (Due: 01/09/2025) V
						#3: Call supplier X
						
						Summary: 2 task(s) pending
				*/
       }
    }

	//only part of the code
    public  class TaskItem
    {
        public int Id { get; }
        public string Title { get; private set; }
        public DateTime? DueDate { get; private set; }
        public bool IsDone { get; private set; }
	}
}
