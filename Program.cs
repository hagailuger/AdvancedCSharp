
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
			board.Add(t3);
			
			var toComplete = board.FindById(2);
			if (toComplete != null)
			{
				toComplete.MarkDone();
			}
			
			Console.WriteLine("=== All Tasks ===");
			board.PrintAll();
			
			var pending = board.GetPendingCount();
			var summary = pending == 0 ? "All done 🎉" : $"{pending} task(s) pending";
			Console.WriteLine($"\nSummary: {summary}");
       }
    }
