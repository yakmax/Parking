
/* Описать класс «автостоянка». 
 * Для каждого автомобиля записываются госномер, цвет, фамилия владельца и признак присутствия на стоянке. 
 * Обеспечить возможность поиска автомобиля по разным критериям, 
 * вывода списка присутствующих и отсутствующих на стоянке автомобилей, 
 * доступа к имеющимся сведениям по номеру места.*/

using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking park1 = new Parking();

            park1[0] = new Car("A001BC", "Черный", "Якимов", true);
            park1[1] = new Car("B099BC", "Черный", "Якимов", false);
            park1[2] = new Car("C022XC", "Серебристый", "Якимов", true);
            park1[3] = new Car("E001KC", "Черный", "Якимов", true);
            park1[4] = new Car("H099HC", "Красный", "Якимов", false);
            park1[5] = new Car("K022MC", "Черный", "Якимов", true);
            park1[6] = new Car("O001PC", "Белый", "Якимов", true);
            park1[7] = new Car("A088HC", "Красный", "Якимов", false);
            park1[8] = new Car("K099MC", "Черный", "Якимов", true);
            park1[9] = new Car("B010PC", "Белый", "Якимов", true);

            Console.WriteLine("**********");
            Console.WriteLine("Вывод авто присутствующих на стоянке");
            park1.CarParkedPrint(true);

            Console.WriteLine("**********");
            Console.WriteLine("Вывод авто отсутствующих на стоянке");
            park1.CarParkedPrint(false);

            Console.WriteLine("**********");
            Random rnd = new Random();
            int rndplace = rnd.Next(0, 14);
            Console.WriteLine("Доступ к имеющимся сведениям по номеру места, например место {0}", rndplace + 1);
            if (park1[rndplace] != null)
            {
                Console.Write("Место: {0}, номер: {1}, цвет: {2}, владелец: {3}", rndplace + 1, park1[rndplace].number, park1[rndplace].color, park1[rndplace].owner);
                if (park1[rndplace].isparked == true) Console.WriteLine(", присутствует "); else Console.WriteLine(", отсутствует");
            }
            else
            {
                Console.WriteLine("Место не занято");
            }

            //Поиск авто по разным критериям
            Console.WriteLine("**********");
            Console.WriteLine("Поиск авто по номеру A001BC");
            park1.CarSearchByNumber("A001BC");

            Console.WriteLine("**********");
            Console.WriteLine("Поиск авто по владельцу Якимов");
            park1.CarSearchByOwner("Якимов");
        }
    }
}
