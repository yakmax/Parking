﻿
/* Описать класс «автостоянка». Для каждого автомобиля записываются 
 * госномер, цвет, фамилия владельца и признак присутствия на стоянке. 
 * Обеспечить возможность поиска автомобиля по разным критериям, 
 * вывода списка присутствующих и отсутствующих на стоянке автомобилей, 
 * доступа к имеющимся сведениям по номеру места.*/

/* Так как сущность "машина" имеет смысл только внутри стоянки, то она будет содержать номер места на стоянке */
/* и признак нахождения на стоянке в данный момент */
/* Сущность "стоянка" позволяет понять сколько машин стоит, сколько мест занято, искать машину и т.п.*/

using System;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking park1 = new Parking();
            park1[0]= new Car("A001BC", "Черный", "Якимов", 40, true);
            park1[99] = new Car("B099BC", "Черный", "Якимов", 41, true);
            park1[22] = new Car("C022BC", "Черный", "Якимов", 42, false);

            Console.WriteLine(park1[99].place);
            Console.WriteLine(park1[22].place);
        }
    }
}