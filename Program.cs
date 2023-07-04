namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name DOG ");
            var NameDog = Console.ReadLine();
            var dog = new Dog();
            dog.SetName(NameDog);
            Console.WriteLine($"{dog.GetName()}");
            dog.Eat();
        }
    }
}