using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Materick A = new Materick();
            Console.Write("Введите название материка: ");
            A.Manterick_name = Console.ReadLine();
            Console.Write("Введите название планеты: ");
            Planet Kepler = new Planet(A, Console.ReadLine());
            Console.WriteLine("Планета: {0}", Kepler.Planet_name);
            Console.WriteLine("Материк: {0}", Kepler.Get_Materick_name);
            Console.WriteLine("Кол. материков: {0}", Kepler.Kol);
            Console.ReadKey();
            Console.Write("Сколько окон: ");
            Home Dom = new Home();
            Dom.A.Kol_window = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько дверей: ");
            Dom.B.Kol_doar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Закрыть дом: ");
            Console.WriteLine("1: Да");
            Console.WriteLine("2: Нет");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    Dom.Close_Or_Open = true;
                    break;
                case 2:
                    Dom.Close_Or_Open = false;
                    break;
                default:
                    Dom.Close_Or_Open = false;
                    break;
            }
            Console.WriteLine("Кол. окон: {0}", Dom.A.Kol_window);
            Console.WriteLine("Кол. дверей: {0}", Dom.B.Kol_doar);
            if (Dom.Close_Or_Open == true)
            {
                Console.WriteLine("Дом закрыт");
            }
            else
            {
                Console.WriteLine("Дом открыт");
            }
            Console.ReadKey();
        }
    }
}