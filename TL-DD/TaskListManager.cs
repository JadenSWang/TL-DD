using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TL_DD
{
    public class TaskListManager : INotifyPropertyChanged
    {
        public TaskListManager()
        {
            this._tasks = new ObservableCollection<Task>();
            this._tasks.Add(new Task("TestName1", "TestDescription1"));
            this._tasks.Add(new Task("TestName2", "TestDescription2"));
        }

        private ObservableCollection<Task> _tasks;
        public ObservableCollection<Task> Tasks
        {
            get { return _tasks; }
            private set { }
        }

        public void AddTask(Task toAdd)
        {
            _tasks.Add(toAdd);
            OnPropertyChanged();
        }

        public void RemoveTask(Task toRemove)
        {
            _tasks.Remove(toRemove);
            OnPropertyChanged();
        }


        #region Boilerplate
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
