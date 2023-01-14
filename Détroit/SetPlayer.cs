using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Détroit
{
    static class SetPlayer
    {
        public static Player information()
        {
            Console.WriteLine("Введіть своє імя");
           string name = Console.ReadLine();
            Console.WriteLine("Введіть свій вік");
            int age = Convert.ToInt32(Console.ReadLine());
            Player tmp = new Player(name, age);
            return tmp;
        }
    }
}
