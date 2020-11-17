using System;

namespace Parking
{
    class Parking
    {
        private Car[] places = new Car[100];

        //индексатор
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

        public void CarParkedPrint(bool p)
        {
            for (int i = 0; i < places.Length; i++)
            {
                if (places[i] != null)
                {
                    if (p == places[i].isparked) Console.WriteLine("Место: {0}, номер: {1}, цвет: {2}, владелец: {3}", i + 1, places[i].number, places[i].color, places[i].owner);
                }
            }
        }

        public void CarSearchByNumber(string n)
        {
            for (int i = 0; i < places.Length; i++)
            {
                if (places[i] != null) if (places[i].number == n)
                    {
                        Console.Write("Место: {0}, номер: {1}, цвет: {2}, владелец: {3}", i + 1, places[i].number, places[i].color, places[i].owner);
                        if (places[i].isparked == true) Console.WriteLine(", присутствует "); else Console.WriteLine(", отсутствует");
                    }
            }
        }

        public void CarSearchByOwner(string o)
        {
            for (int i = 0; i < places.Length; i++)
            {
                if (places[i] != null) if (places[i].owner == o)
                    {
                        Console.Write("Место: {0}, номер: {1}, цвет: {2}, владелец: {3}", i + 1, places[i].number, places[i].color, places[i].owner);
                        if (places[i].isparked == true) Console.WriteLine(", присутствует "); else Console.WriteLine(", отсутствует");
                    }
            }
        }
    }
}
