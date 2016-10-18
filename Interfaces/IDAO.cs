using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDAO
    {
        IEnumerable<IProducer> GetAllProducers();
        IEnumerable<ICar> GettAllCars();

        IEnumerable<IQuestion> GetAllQuestions();
        IQuestion CreateNewQuestion();
        void AddQuestion(IQuestion question);
        //IEnumerable<IUser> GetAllUsers();
        //IUser CreateNewUser();

        ICar CreateNewCar();
        void AddCar(ICar car);

    }
}
