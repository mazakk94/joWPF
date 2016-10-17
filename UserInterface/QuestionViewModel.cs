using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class QuestionViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private IQuestion _question;

        public QuestionViewModel(IQuestion question)
        {
            _question = question;

        }

        public int Id
        {
            get { return _question.Id; }
            set
            {
                _question.Id = value;
                //RaisePropertyChanged("QuestionId");
            }
        }
        
        public int Points
        {
            get { return _question.Points; }
            set
            {
                _question.Points = value;
                //RaisePropertyChanged("name");
            }
        }

        public string Content
        {
            get { return _question.Content; }
            set
            {
                _question.Content = value;
                //RaisePropertyChanged("Coor");
            }
        }
        public List<Tuple<string, bool>> Answer
        {
            get { return _question.Answer; }
            set
            {
                _question.Answer = value;
                //RaisePropertyChanged("Producent");
            }
        }
        
        

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public System.Collections.IEnumerable GetErrors(string propertyName)
        {
            throw new NotImplementedException();
        }

        public bool HasErrors
        {
            get { throw new NotImplementedException(); }
        }
    }
}
