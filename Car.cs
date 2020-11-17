namespace Parking
{
    class Car
    {
        public string number { get; set; }         // госномер
        public string color { get; set; }         // цвет
        public string owner { get; set; }        // фамилия владельца
        public bool isparked { get; set; }      //признак присутствия на стоянке.

        public Car(string number, string color, string owner, bool isparked)
        {
            //конструктор
            this.number = number;
            this.color = color;
            this.owner = owner;
            this.isparked = isparked;
        }
    }
}
