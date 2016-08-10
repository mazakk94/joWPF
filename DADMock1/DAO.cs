using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADMock1
{
    public class DAO : IDAO
    {

        private List<IProducer> _producers;
        private List<ICar> _cars;

        public DAO()
        {
            _producers = new List<IProducer>()
            {
                new BO.Producer(){ ProducerID = 1, Name = "one"},
                new BO.Producer(){ ProducerID = 2, Name = "two"},
                new BO.Producer(){ ProducerID = 3, Name = "three"}

            };

            _cars = new List<ICar>()
            {
                new BO.Car() { CarID = 6, Name = "Polo6", Producer = _producers[1], Price = 45, Color = "Red"},
                new BO.Car() { CarID = 1, Name = "Polo1", Producer = _producers[0], Price = 260, Color = "Black"},
                new BO.Car() { CarID = 2, Name = "Polo2", Producer = _producers[0], Price = 270, Color = "Red"},
                new BO.Car() { CarID = 3, Name = "Polo2", Producer = _producers[1], Price = 260, Color = "White"},
                new BO.Car() { CarID = 4, Name = "Polo4", Producer = _producers[1], Price = 45, Color = "Red"},
                new BO.Car() { CarID = 5, Name = "Polo5", Producer = _producers[1], Price = 45, Color = "Red"}
                
            };

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
            return new BO.Car();
        }

        public void AddCar(ICar car)
        {
            _cars.Add(car);
        }
    }
}
