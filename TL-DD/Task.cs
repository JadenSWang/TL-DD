using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TL_DD
{
    public class Task : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private int _durationMin;
        private string _code;
        private DateTime _dueDate;
        private bool _completed;

        public Task(string name, string description)
        {
            this._name = name;
            this._description = description;
            this._code = name.Substring(0,1);
        }

        public Task(string name, string description, string code)
        {
            this._name = name;
            this._description = description;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name.Equals(value)) return;

                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (_description.Equals(value)) return;

                _description = value;
                OnPropertyChanged();
            }
        }

        public int Duration
        {
            get { return _durationMin; }
            set
            {
                if (_description.Equals(value)) return;

                _durationMin = value;
                OnPropertyChanged();
            }
        }

        public string Code
        {
            get { return _code; }
            set
            {
                if (_code.Equals(value)) return;

                _code = value;
                OnPropertyChanged();
            }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                if (_dueDate.Equals(value)) return;

                _dueDate = value;
                OnPropertyChanged();
            }
        }

        public bool Completed
        {
            get { return _completed; }

            set
            {
                if (_completed == value) return;

                _completed = value;
                OnPropertyChanged();
            }
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
