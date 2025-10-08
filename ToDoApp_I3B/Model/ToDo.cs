using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp_I3B.Model
{
    public class ToDo : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Title { get; set; }
        private bool _isDone;

        public ToDo() { }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsDone)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
