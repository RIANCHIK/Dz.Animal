using System;


namespace DZ.Animal
{
    class Herbivore : Animal
    {
        public override void Jump()
        {
            Console.WriteLine("Я прыгаю очень далеко..");
        }
        public Herbivore()
        {

        }
        
        public Herbivore(string Name, string Age, string Weight, string Speed)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Speed = Speed;
        }
    }
}
