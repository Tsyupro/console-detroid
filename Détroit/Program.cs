
using Détroit;
int a = 1;
Console.WriteLine("Вітаємо у грі Детроїд");
Gamer gamer = new Gamer();
Console.Clear();
while (a != 2)
{
    Game player = new Game();

    Console.WriteLine(" 1 - Розпочати гру\n 2- Вийти з гри ");
    a = player.Choice(2);

    if (a == 1)
    {
        player.Scene_Beginning();
        player.Scene_Evidence();
        player.Scene_Balcony();
        FileGameHelper.RecordАFile(gamer, player);
        FileGameHelper.Text_Output();
    }
    else if (a==2)
    {
        Console.Clear();
        Console.WriteLine("Дякуємо за гру!");
    }
}
