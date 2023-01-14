

namespace Détroit
{
    static class GameProgress
    {
        public static void SetProgress(Player player,Game gamer)
        {
            try
            {
                if (File.Exists("winners.txt"))
                {
                    using (Stream stream = File.Open("winners.txt",FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(stream))
                        {
                            sw.WriteLine("Name " + player.name + " | age " + Convert.ToString(player.age) + " | % " + Convert.ToString(gamer.success));
                        }                          
                    }
                }
                else
                {
                    using (Stream stream = File.Create("winners.txt"))
                    {
                        using (StreamWriter sw = new StreamWriter(stream))
                        {
                            sw.WriteLine("Name " + player.name + " | age " + Convert.ToString(player.age) + " | % " + Convert.ToString(gamer.success));
                        }
                    }
                }
                    
                  
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
       public  static void GetProgress()
        {
            try 
            {
                if (File.Exists("winners.txt"))
                {
                    using (Stream stream = File.OpenRead("winners.txt"))
                    using (StreamReader reader = new StreamReader("winners.txt"))                   
                        Console.WriteLine(reader.ReadToEnd());                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
