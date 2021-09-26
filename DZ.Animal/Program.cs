using System;
using System.Collections.Generic;
using System.Linq;


namespace DZ.Animal
{
    class Program
    {
        static void Main()
        {
            Herbivore kangaroo = new Herbivore("Кенгуру ", "Возраст 6 лет ", "Вес: 82кг ", "Скорость:50 км/ч ");
            Console.WriteLine(kangaroo.Name);
            Console.WriteLine(kangaroo.Age);
            kangaroo.Jump();
            kangaroo.Pregnancy();
           
            
           
             List<Animal> animals = new List<Animal>()

            {
                new Animal("Кошка","7","5 кг","13,8 км/ч"),
                new Animal("Тигр","3","300 кг","80 км/ч"),
                new Animal("Пантера","2","190 кг","95,5 км/ч"),
                new Animal("Гепард","3","65 кг","120 км/ч"),
                new Animal("Тушканчик","1","300 гр"," 50 км/ч"),

            };
            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
            }

            Animal animal = new Animal();
            animal.Jump();
            Herbivore herbivore = new Herbivore();
            herbivore.Jump();
            

            Predator tiger = new Predator();
            Console.WriteLine(tiger.Name);
            tiger.eats();

            Console.ReadKey();


        }
    }
}
