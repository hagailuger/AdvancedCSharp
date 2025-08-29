using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public sealed class TaskBoard
    {
        private readonly TaskItem[] _items;
        private int _count;

        public TaskBoard(int capacity)
        {
            _items = new TaskItem[capacity];
            _count = 0;
        }

        public bool Add(TaskItem task)
        {
            if (_count >= _items.Length) 
                return false;
            _items[_count] = task;
            _count++;
            return true;
        }

        public int Count => _count;

        public int GetPendingCount()
        {
            int pending = 0;
            for (int i = 0; i < _count; i++)
            {
                if (!_items[i].IsDone)
                    pending++;
            }
            return pending;
        }

        public void PrintAll()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_items[i].ToString());
            }
        }

        public TaskItem FindById(int id)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Id == id)
                    return _items[i];
            }
            return null; 
        }

        public void PrintPendingSummary()
        {
            var pending = GetPendingCount();
            var summary = pending == 0 ? "All done 🎉" : $"{pending} task(s) pending";
            Console.WriteLine($"\nSummary: {summary}");
        }
    }
}
