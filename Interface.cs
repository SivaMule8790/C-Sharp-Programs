using System;

    // Define the IAnimal interface
public interface IAnimal
    {
        void Speak();
        void Eat();
    }

    // Define the IPet interface that inherits from IAnimal
public interface IPet : IAnimal
    {
        void Play();
    }

    // Implement the Dog class
public class Dog : IPet
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }

        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Play()
        {
            Console.WriteLine("Dog is playing fetch!");
        }
    }

    // Implement the Cat class
public class Cat : IPet
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }

        public void Eat()
        {
            Console.WriteLine("Cat is eating.");
        }

        public void Play()
        {
            Console.WriteLine("Cat is playing with a toy!");
        }
    }

    // Implement the Bird class with explicit interface implementation
public class Bird : IAnimal
    {
        void IAnimal.Speak()
        {
            Console.WriteLine("Chirp!");
        }

        public void Eat()
        {
            Console.WriteLine("Bird is eating seeds.");
        }
    }

    // Main program to demonstrate the usage of interfaces
public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of Dog and Cat  //interface obj=new class();
            IPet myDog = new Dog();
            IPet myCat = new Cat();
            IAnimal myBird = new Bird();

            // Call methods on Dog
            Console.WriteLine("Dog:");
            myDog.Speak();
            myDog.Eat();
            myDog.Play();

            Console.WriteLine();

            // Call methods on Cat
            Console.WriteLine("Cat:");
            myCat.Speak();
            myCat.Eat();
            myCat.Play();

            Console.WriteLine();

            // Call methods on Bird (explicit implementation)
            Console.WriteLine("Bird:");
            myBird.Speak(); // Cast to IAnimal to access Speak
            myBird.Eat();
        }
}