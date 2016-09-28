using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class DAO : IDAO
    {

        private List<IProducer> _producers;
        private List<ICar> _cars;
        
        public DAO()
        {
            _producers = new List<IProducer>()
            {
                new DataObjects.Producer(){ ProducerID = 1, Name = "one"},
                new DataObjects.Producer(){ ProducerID = 2, Name = "two"},
                new DataObjects.Producer(){ ProducerID = 3, Name = "three"}
            };

            _cars = new List<ICar>()
            {
                new DataObjects.Car() { CarID = 6, Name = "Polo6", Producer = _producers[1], Price = 45, Color = "Red"},
                new DataObjects.Car() { CarID = 1, Name = "Polo1", Producer = _producers[0], Price = 260, Color = "Black"},
                new DataObjects.Car() { CarID = 2, Name = "Polo2", Producer = _producers[0], Price = 270, Color = "Red"},
                new DataObjects.Car() { CarID = 3, Name = "Polo2", Producer = _producers[1], Price = 260, Color = "White"},
                new DataObjects.Car() { CarID = 4, Name = "Polo4", Producer = _producers[1], Price = 45, Color = "Red"},
                new DataObjects.Car() { CarID = 5, Name = "Polo5", Producer = _producers[1], Price = 45, Color = "Red"}
                
            };
            /*
            _questions = new List<IQuestion>()
            {
                new DataObjects.Question() 
                { 
                    Id = 0, Content = "Yellow electric mouse?", Points = 1, Answer = new List<Tuple<string,bool>>
                    { 
                        new Tuple<string, bool>("Electabuzz", false), 
                        new Tuple<string, bool>("Zapdos", false), 
                        new Tuple<string, bool>("Pikachu", false)
                    }
                }
                
            };

            _tests = new List<ITest>()
            {
                new DataObjects.Test() { Name = "Pokemon Test", Length = new TimeSpan(1, 0, 0), MaximumPoints = 10, Questions = { _questions[0] } }
            };
            */
        }

        public IEnumerable<IProducer> GetAllProducers()
        {
            return _producers;
        }

        public IEnumerable<ICar> GettAllCars()
        {
            return _cars;
        }



        public ICar CreateNewCar()
        {
            return new DataObjects.Car();
        }

        public void AddCar(ICar car)
        {
            _cars.Add(car);
        }



       
        private List<IAnsweredQuestion> _answeredQuestions;
        private List<IHistory> _histories;
        private List<IQuestion> _questions;
        private List<ITest> _tests;
        private List<IUser> _users;


        public IEnumerable<IAnsweredQuestion> GetAllAnsweredQuestions()
        {
            return _answeredQuestions;
        }

        public IEnumerable<IHistory> GetAllHistories()
        {
            return _histories;
        }

        public IEnumerable<IQuestion> GetAllQuestions()
        {
            return _questions;
        }

        public IEnumerable<ITest> GetAllTests()
        {
            return _tests;
        }

        /*
        public ITest GetTest(int id)
        {
            return _tests.Where(test => test.Id == id);
        }
         * */

        public IEnumerable<IUser> GetAllUsers()
        {
            return _users;
        }


        public ITest CreateNewTest()
        {
            return new DataObjects.Test();
        }

        public void AddTest(ITest test)
        {
            _tests.Add(test);
        }

        public void AddQuestion(IQuestion question)
        {
            _questions.Add(question);
        }

        public void AddQuestionToTest(ITest test, IQuestion question)
        {
            
        }


    }
}
