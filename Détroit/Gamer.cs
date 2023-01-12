namespace Détroit
{
    public class Gamer
    {
        public string name{ get;}
        public  int age { get; }

        public Gamer()
        {
            Console.WriteLine("Введіть своє імя");
            name = Console.ReadLine();
            Console.WriteLine("Введіть свій вік");
            age = Convert.ToInt32(Console.ReadLine());
        }


    }
}
