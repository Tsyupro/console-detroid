namespace Détroit
{
     public class Game
    {
        bool name = false,gun=false,reason=false;
        
        public int success = 50;
        public void Scene_Beginning()
        {
            int test;
            Console.WriteLine("15 квiтня 2038 рiк\n20:09:04\n Герой направляється в лiфтi на поверх 56\n ");
            TextGo("Cпецназ - перемовник прибув", 80);
            Console.WriteLine("Ви побачили сімейну фотографію\n 1- Поглянути \n 2-Пройти повз ");
            if (Choice(2) == 1)
            {
                TextGo("Джон Фiлiпс дата нароження 11.10.1999, \nЕмма Фiлiпс Дата народження 02.09.2028", 75);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Пiдбiгає матiр Дiвчини");
            TextGo("Матiр- благаю врятуйте мою дiвчинку\r\nзачекайте  ви посилаєте андроїда?\r\nСпецназ - ну все панi пiшли\r\n(Жiночий крик) - Що ви робите? це ж не жива людина! там моя дитина!!!", 80);


            Console.WriteLine("Для продовження натиснiть будь-яку клавiшу =)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Зайшли в кiмнату до підготовчої групи спецназу");
            Console.WriteLine("-1 поговорити з капiтаном Алленом ");

            if (Choice(1) == 1)
            {

                TextGo("Коннор-моє iм'я Конор,  Андроїд присланий з Кіберлайф\r\nКапiтан - Вiн стрiляє по всьому що рухається\r\nуже пiдстрелив двох моїх людей\r\nСнайпери зняли би його але вiн стоїть на краю\r\nЯкщо впаде\r\nто разом з нею", 80);
                Console.WriteLine("-1 iм'я Девіанта\n -2 поведiнка девiанта \n 3 -код деактевацiї");
                for (int i = 0; i < 2; i++)
                {
                    test = Choice(3);
                    if (test == 1)
                    {
                        TextGo("Коннор-Ви знаєте імя Девiанта?\n Капiтан - без поняття", 80);
                    }
                    else if (test == 2)
                    {
                        TextGo("Коннор-У цієї машини раніше зустрічались збої?\n Капiтан - та без поняття. це важливо?\r\nКоннор- мені потрібна інформація щоб знайти пiдхiд", 80);
                    }
                    else if (test == 3)
                    {
                        TextGo("Коннор-Ви застосовували код деактивації?\r\nКапiтан - так в першу чергу \r\n", 80);
                    }
                }
                TextGo("Капiтан - Слухай,зараз головне врятувати дитину,або ти розбираєшся з цiєю машиною, або розберусь я", 80);

                Console.WriteLine("Для продовження натиснiть будь-яку клавiшу =)");
                Console.ReadKey();
                Console.Clear();
                Success(success, 4,false);
                Console.WriteLine("( Ваша місія врятувати заручницю будь-якою ціною )");
            }
        }
        public void Scene_Evidence()
        {
            Console.WriteLine("Конор заходить у вітальню ");
            Console.WriteLine("Бачите чемодан від пістолета\n1-Оглянути | 2- пройти мимо");
            if(Choice(1) == 1)
            {
                Analysis();
                TextGo(" MS853 Black Hawk Ємкість магазину 17 патронів калібра 355 сумарний розмір 21.6 см/ дуло 12.7 см", 60);

            }
            Console.WriteLine("Бачите вхід в кімнату дівчинки ");
            Console.WriteLine("1-Зайти  | 2- Пройти ближче до балкону");
            if (Choice(1) == 1)
            {
                Console.WriteLine("Знаходите планшет і дізнаєтесь імя Девіанта ");
                TextGo("Даніель", 80);
                name = true;
                TextGo("(ви розблукували діалог або дію (це не рідко буває корисним ))", 80);
                Console.WriteLine("Для продовження натиснiть будь-яку клавiшу =)");
                Console.ReadKey();
                Success(success, 6);
            }
            Console.WriteLine("Ви зайшли в кімнату яка веде до балкону");
            Console.WriteLine("Оглядаєтесь");
            Console.WriteLine("ваші діі");
            Console.WriteLine("1 -  переглянути планшет батька - побачили сайт про попупку нового андроїда");
            Console.WriteLine("2 - переглянути новини");
            Console.WriteLine("3-оглянути тіло поліцейського");
            Console.WriteLine("4- Направитись до балкону");
            int test = Choice(4);
            while (test != 4)
            {
                if (test == 1)
                {
                    Console.WriteLine("побачили сайт про попупку нового андроїда");
                    TextGo("(андроїда хотіли замінити)", 80);
                    reason = true;
                    Success(success, 6);
                }
                if(test == 2)
                {
                    Console.WriteLine("бачити новину про те що це може бути перша спроба Андроїда зробити самосуд над людьми");
                }
                if (test == 3)
                {
                    Console.WriteLine("співробітник прибув на місце виклику першим");
                    Analysis();
                    TextGo("Ентоні Декарт | Ріст 177см | вага 77 кг | приблизнний час смерті 20:03 ", 80);
                    TextGo("вступив в перестрілку з Девіантом | зброя знайдена", 80);
                    Console.WriteLine("1- підняти зброю / 2-залишити на місті ");
                    if (Choice(1) == 1)
                    {
                        Success(success, 4);
                        gun = true;
                    }

                }
                test = Choice(4);
            }

        }

        public void Scene_Balcony()
        {

            Console.WriteLine("Ви зайшли на балкон, прямуючи до Девіанта");
            if (name)
            {
                TextGo("Коннор - Даніель\nДаніель-звідки ти?\nКоннор- моє імя Коннор\nДаніель- звіки ти знаєш моє імя?\nКоннор- я багато про тебе знаю,я прийшов тебе виручити!  ", 80);
            }
            else
            {
                TextGo("Коннор - моє Імя Коннор , яке твоє імя?\nДаніель-Даніель, так вони мене називали.", 80);
            }

            Console.WriteLine("Підлітає вертоліт поліції");
            Console.WriteLine("Для продовження натиснiть будь-яку клавiшу =)");
            Console.ReadKey();
            Console.Clear();
            Success(success, 4, false);

            Console.WriteLine("Завдання - Завоювати довіру Девіанта");
            Console.WriteLine("1-Спокійно");
            if (reason)
            {
                Console.WriteLine("8%8  2- Можлива причина");
            }
            else
            {
                Console.WriteLine("///////");  
            }
            if (name)
            {
                Console.WriteLine("8%8  3- Емма і ти ");
            }
            else
            {
                Console.WriteLine("///////");
            }
            Console.WriteLine("4- Реалістично ");
            int test = Choice(4);
            if(test == 1)
            {
                TextGo("Коннор - Ти не тямиш себе від люті Даніель. але довірся мені дозволь тобі допомогти\nне потрібно мені допомагати мені ніхто не допоможе я просто хочу щоб це все закінчилося", 80);

            }
            else if(test == 2 && reason)
            {
                TextGo("Коннор -тебе хотіли замінити на іншу модель  і ти засмучений так? \nДаніель - я думав я для них частина сімї що я їм важливий а був іграшкою ", 80);
                Console.WriteLine("Для продовження натиснiть будь-яку клавiшу =)");
                Console.ReadKey();
                Success(success, 6);

            }
            else if (test==3 && name)
            {
                TextGo("Коннор - Ви з Емою були близькі я знаю  ти думаєш що тебе зрадили але вона не винна\nДаніель-вона мене ввела в оману, а говорила що любить, а сама берахала вона - така ж як усі люди ", 80);
                Console.WriteLine("Для продовження натиснiть любу клавiшу =)");
                Console.ReadKey();
                Success(success, 6);
            }
            else if (test == 4)
            {
                TextGo("Коннор - слухай ти ж не винен, це просто збій програмного коду \nДаніель-Ні я не винен, я цього не хотів, я любив їх але дя них я був ніким тільки щоб справно виконував накази ", 80);

            }

            TextGo("Даніель - у тебе є зброя?", 80);
            Console.WriteLine("1-збрехати / 2- сказати правду");
            test=Choice(2);
            if (test == 1)
            {
                TextGo("Коннор  - ні я без зброї\n Даніель - ти брешеш у тебе пістолет\n Коннор- я говорю тобі правду!", 80);
            }
            else if (test == 2)
            {
                TextGo("Коннор  - так\n Даніель - кидай його, без різких рухів", 80);
                Console.WriteLine("Коннор викинув пістолет");
                gun=false;
            }

            TextGo("Даніель - як же мене бісить цей звук , накажи вертоліту забиратись ", 80);
            Console.WriteLine("1- Погодитися , 2- Відмовитись ");
            test = Choice(2);
            if( test == 1)
            {
                Console.WriteLine("Конор показав жестом щоб верталіт забирався\\ верталіт полетів геть");
                TextGo("Коннор - ось я виконав твоє бажання ", 80);
                Console.WriteLine("Для продовження натиснiть будь-яку клавiшу =)");
                Console.ReadKey();
                Success(success, 6);
            }
            else if (test == 2)
            {
                Console.ReadKey();
                Success(success, 6,false);
            }
            Console.WriteLine("1-Блеф / 2- Довіритися / 3- Пожертвувати собою");
            if (gun)
            {
                Console.WriteLine(" 4 -Дістати пістолет ");
            }
            else
            {
                Console.WriteLine("4  /////// ");
            }
            test= Choice(4);
            if(test == 1)
            {
                TextGo("Коннор -ти ж не хочеш стрибати інакше стрибнув би давно віддаай пістолет\r\nДаніель  - не підходь ближче , ще крок і я стрибну  ", 80);
                Console.WriteLine("1- Підійти ближче / 2-відступити");
                int test2= Choice(2);
                TextGo("Д- все життя я виконував накази , тепер сам буду вирішувати", 80);
                Console.WriteLine("(девіант спробував стрибнути)");
                Thread.Sleep(3000);
                if (test2 == 1)
                {
                    Console.WriteLine("Коннор пожертував собою стрибнувши з девіантом в низ");
                    Console.WriteLine("Дівчина врятована");
                    Console.WriteLine("Завдання виконано!");
                }
                else if(test2 == 2)
                {
                    Console.WriteLine("Коннор хотів пожертвувати  собою стрибнути з девіантом вниз, але не встиг добігти");
                    Console.WriteLine("Дівчина та девіант мертві");
                    Console.WriteLine("Завдання провалено!!");
                }
            }
            else if(test == 2)
            {
                TextGo("Коннор  - ти повинен мені довіритися відпусти дитину і я обіцяю що все буде гаразд\n Даніель - мені потрібна машина я поіду за місто і там відпущу її \n Коннор- це не можливо. відпусти дитину і я обцію тебе пожаліють\n Даніель -добре, я повірю! ", 80);
                Console.WriteLine("Девіант відпустив дитину ");
                Thread.Sleep(1000);
                Console.WriteLine("Снайпери з дахів розcтріляли Девіанта");
                TextGo("Даінель -Ти збрехав мені конор. ти збрехав\r\n ", 80);
                Console.WriteLine("Місія виконана!");
            }
            else if (test == 3)
            {
                Console.WriteLine("Конор скинув Девіанта з криші але отримав кілька вистрілів в спину \r\nКонор мертвий Дівчинка жива");
                Console.WriteLine("Завдання виконано!");
            }
            else if(test==4 && gun)
            {
                Console.WriteLine("Конор націлив пістолет на девіанта а Девіант на нього!");
                Console.WriteLine("1-Вистріл / 2- запугати");
                test= Choice(2);
                if (test == 1)
                {
                    Console.WriteLine("Конор вестрілив прямо в голову");
                    Thread.Sleep(3000);
                    Console.WriteLine(" Девіант мертвий дівчинка жива");
                    Thread.Sleep(3000);
                    Console.WriteLine("Завдання виконано!");
                }
                else
                {
                    TextGo(" Коннор - і що Данілель? ти правда цьго хочеш? ", 80);
                }
                Console.WriteLine("1- Вистрілити / 2- Запевнити");
                test = Choice(2);
                if(test == 1)
                {
                    Console.WriteLine("Конор вестрілив прямо в голову");
                    Thread.Sleep(3000);
                    Console.WriteLine(" Девіант мертвий дівчинка жива");
                    Thread.Sleep(3000);
                    Console.WriteLine("Завдання виконано!");
                }
                else
                {
                    TextGo("Коннор - Фінал залежить від тебе! ", 80);
                    Console.WriteLine("Коннор отримав пулю в лоб , Коннор мертвий ");
                    TextGo("Я цьго не хотів , ти не залишив мені вибору! ", 80);
                    Console.WriteLine("Девіант стрибнув з Дівчинкою");
                    Thread.Sleep(3000);
                    Console.WriteLine(" всі мертві ");
                    Thread.Sleep(3000);
                    Console.WriteLine("Завдання провалено!");
                }
            }          

        }


        private void TextGo(string tmp, int timer)
        {
            char[] textChar = tmp.ToCharArray();
            foreach (char c in textChar)
            {
                Console.Write(c);
                Thread.Sleep(timer);

            }
            Console.WriteLine();
        }
        public int Choice(int maxNumber)
        {
            Console.WriteLine("Ваш вибiр : ");
            string? tmp = Console.ReadLine();
            int number = Convert.ToInt32(tmp);
            while (maxNumber < number || number <=0)
            {
                Console.WriteLine("Вихiд за дiапазон! Спробуйте ще раз : ");
                tmp = Console.ReadLine();
                number = Convert.ToInt32(tmp);
            }
            return number;
        }
        private int Success(int number, int tmp,bool level=true)
        {
            Console.Write("Рiвень успiху : ");
           if(level)
            for (int i = 0; i < tmp; i++)
            {
                Console.Write(++number + "%");
                Thread.Sleep(500);
                Console.Clear();
                Console.Write("Рiвень успiху : ");

            }
            else
            {
                for (int i = 0; i < tmp; i++)
                {
                    Console.Write(--number + "%");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.Write("Рiвень успiху : ");

                }
            }
            Console.WriteLine(number + "%");
            return number;
        }
        private void Analysis()
        {
            Console.Write("Аналіз Данних :");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("%");
                Thread.Sleep(500);
                Console.Write("/");


            }
            Console.WriteLine();
        }
        public void Start(Game game)
        {
            int a = 1;
            Player player = SetPlayer.information();
            while (a != 3)
            {
                Console.WriteLine(" 1 - Розпочати гру\n 2- Таблиця рекордів\n 3-Вийти з гри ");
                a = game.Choice(3);

                if (a == 1)
                {
                    game.Scene_Beginning();
                    game.Scene_Evidence();
                    game.Scene_Balcony();
                    GameProgress.SetProgress(player, game);
                }
                else if (a == 2)
                {
                    GameProgress.GetProgress();
                }
                else if (a == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Дякуємо за гру!");
                }
            }
        }

    }
}

