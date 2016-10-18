using Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace UserInterface
{
    public class QuestionListViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<QuestionViewModel> _questions;
        private IDAO _dao;

        private RelayCommand _addQuestionCommand;

        public ObservableCollection<QuestionViewModel> Questions
        {
            get { return _questions; }
            set
            {
                _questions = value;
                RaisePropertyChanged("Questions");
            }
        }

        public QuestionListViewModel()
        {
            _questions = new ObservableCollection<QuestionViewModel>();
            _dao = new DataAccessObject.DAO();
            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(_questions);
            FilterData = "";
            GetAllQuestions();
            _addQuestionCommand = new RelayCommand(param => this.AddQuestionToList());
            _saveNewQuestionCommand = new RelayCommand(param => this.SaveQuestion(),
                                                  param => this.CanSaveQuestion());
            //_filterDataCommand = new RelayCommand(param => this.DoFilterData());
            //_groupQuestionsCommand = new RelayCommand(param => this.GroupByPrice());

        }

        private void GetAllQuestions()
        {
            foreach (var c in _dao.GetAllQuestions())
            {
                _questions.Add(new QuestionViewModel(c));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /*
         
         */

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand AddQuestionCommand
        {
            get { return _addQuestionCommand; }
        }

        private void AddQuestionToList()
        {
            IQuestion question = _dao.CreateNewQuestion();
            QuestionViewModel qvm = new QuestionViewModel(question);
            _dao.AddQuestion(question);
            Questions.Add(qvm);
            EditedQuestion = qvm;
        }

        private ICommand _saveNewQuestionCommand;

        public ICommand SaveNewQuestionCommand
        {
            get { return _saveNewQuestionCommand; }
        }

        private QuestionViewModel _editedQuestion;

        public QuestionViewModel EditedQuestion
        {
            get { return _editedQuestion; }
            set
            {
                _editedQuestion = value;
                RaisePropertyChanged("EditedQuestion");
            }
        }

        private void SaveQuestion()
        {
            _questions.Add(_editedQuestion);
        }

        private bool CanSaveQuestion()
        {
            if (EditedQuestion == null)
                return false;

            if (EditedQuestion.HasErrors)
                return false;

            return true;
        }

        private RelayCommand _filterDataCommand;

        public RelayCommand FilterDataCommand
        {
            get { return _filterDataCommand; }
        }

        private ListCollectionView _view;

        private string _filterData;

        public string FilterData
        {
            get { return _filterData; }
            set
            {
                _filterData = value;
                RaisePropertyChanged("FilterData");
            }
        }

        /*
        private void DoFilterData()
        {
            if (FilterData.Length > 0)
            {
                _view.Filter = (c) => ((QuestionViewModel)c).Name.Contains(FilterData);
            }
            else
            {
                _view.Filter = null;
            }
        }
         * */

        private RelayCommand _groupQuestionsCommand;

        public RelayCommand GroupQuestionsCommand
        {
            get { return _groupQuestionsCommand; }
        }

        /*
        private void GroupByPrice()
        {
            _view.SortDescriptions.Add(new SortDescription("Price", 
                ListSortDirection.Ascending));
            _view.GroupDescriptions.Add(new PropertyGroupDescription("Price"));
        }
         * */
    }
}
