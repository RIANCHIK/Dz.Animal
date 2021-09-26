using System;


namespace DZ.Animal
{
    public class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Speed { get; set; }

        public Animal()
        {

        }
        public Animal(string Name, string Age, string Weight, string Speed)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Speed = Speed;
        }
        virtual public void Jump()
        {
            Console.WriteLine("Длина прыжка кенгуру может достигать до 3/4м.");
        }
         public void Pregnancy()
        {
            Console.WriteLine("Мать – кенгуру из сумки может выбросить больного ребёнка, чтобы родить здорового."); 
        }
         virtual public void eats()
        {
            Console.WriteLine("В среднем за день взрослый тигр должен съедать 7 — 9 кг мяса, за год 2,5 — 3 тонны");
        }
    }
}
