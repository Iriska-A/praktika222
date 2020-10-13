using System;
using ClassLibrary3;

namespace magazin
{
    class Program
    {
         static void Main(string[] args)
        {
            Mag magg = new Mag("Введите имя", "Введите фамилию", "Введите Email", "Придумайте пароль", "Зарегистрироваться");

            Console.WriteLine(magg.ReturnSurnameMag());


            Console.WriteLine(magg.ReturnNameMag());
            Console.WriteLine(magg.ReturnPasswordMag());
            Console.WriteLine(magg.ReturnEmailMag());
            Console.WriteLine(magg.ReturnInputMag());


            Console.ReadLine();
        }

        class Library3
        {
            public static void Main(string[] args)

            {
                Cl1 can = new Cl1();

                can.Hello("Ирина");

                Console.WriteLine("Как настроение?");
                Console.WriteLine("Через три года вам будет-(can.AgeToThree(18)");
                Console.WriteLine();
                Console.ReadLine();

            }
        }

    }
}

