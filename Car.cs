using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Car
    {

        public string number { get; set; }
        // госномер
        public string color { get; set; } 
        // цвет
        public string owner { get; set; }
        // фамилия владельца
        public int place { get; set; }
        // место
        public bool isparked { get; set; } //признак присутствия на стоянке.

        public Car(string number, string color, string owner, int place, bool isparked)
        //public Car(string number, string color)
        {
            //конструктор
            this.number = number;
            this.color = color;
            this.owner = owner;
            this.place = place;
            this.isparked = isparked;
            
        }
    }
}
