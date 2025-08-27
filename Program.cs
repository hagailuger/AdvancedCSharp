
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
			board.PrintPendingSummary();

				/*	
						  === All Tasks ===
						#1: Buy milk (Due: 28/08/2025) X
						#2: Send report (Due: 01/09/2025) V
						#3: Call supplier X
						
						Summary: 2 task(s) pending
				*/
       }
    }
