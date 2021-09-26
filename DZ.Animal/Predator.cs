using System;


namespace DZ.Animal
{
    class Predator : Animal
    {
        public Predator()
        {

        }

        public override void eats()
        {
            base.eats();
        }

        public Predator (string Name, string Age, string Weight, string Speed)
        {
            this.Name = Name;
            this.Age = Age;
            this.Weight = Weight;
            this.Speed = Speed;
        }
    }
   
    
}
