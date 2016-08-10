using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADMock1.BO
{
    class Car : ICar
    {
        public int CarID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public IProducer Producer
        {
            get;
            set;
        }

        public float Price
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }
    }
}
