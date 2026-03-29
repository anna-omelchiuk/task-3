using prac_2;
using static System.Console;

OutputEncoding = System.Text.Encoding.UTF8;

Magazine mg = new Magazine();

WebSite ws = new WebSite();

Shop sp = new Shop();

Reservoir r1 = new Reservoir(100);
Reservoir r2 = new Reservoir(200, "Сталь");
Reservoir r3 = new Reservoir(150, "Пластик", true);


while (true)
{
    WriteLine("\nКЛАСИ\n");
    WriteLine("1. Журнал");
    WriteLine("2. Веб-сайт");
    WriteLine("3. Магазин");
    WriteLine("4. Резервуар");
    Write("\nВаш вибір: ");
    



    if (int.TryParse(ReadLine(), out int choice))
    {
        switch (choice)
        {
            case 1:
                mg.InputData();
                WriteLine(mg.ToString());
                break;

            case 2:
                ws.InputData(ws);
                WriteLine(ws.ToString());
                break;

            case 3:
                sp.InputData(sp);
                WriteLine(sp.ToString());
                break;

            case 4:
                r1.Fill(50);
                r1.Fill(60);

                r2.Fill(100);
                r2.Empty(30);

                r3.Empty(200);

                r1.ShowInfo();
                r2.ShowInfo();
                r3.ShowInfo();
                break;

            case 0:
                WriteLine("Вихід з програми. До побачення!");
                return;

            default:
                WriteLine("Невірний вибір. Спробуйте ще раз.");
                break;
        }
    }
}
