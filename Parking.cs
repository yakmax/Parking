using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parking
    {
        
        private Car[] places = new Car[100];
        
        public Car this[int index]
        {
            get
            {
                return places[index];
            }
            set
            {
                places[index] = value;
            }
        }

    }
}
