using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Гусак Анна

#region Qestionnaire

/* Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 В результате вся информация выводится в одну строчку:
   а) используя склеивание;
   б) используя форматированный вывод;
   в) используя вывод со знаком $. */

namespace Qestionnaire
{
    class Program
    {
        // Функция для вывода информации методом склеивания
        static string Info(string name, string surname, int age, double height, double weight)
        {
            return "Name: " + name + ", surname: " + surname + ", age: " + age + ", height: " + height + "m, weight: " + weight + "kg.";
        }

        // Функция для форматированного вывода информации 
        static string InfoFormat(string name, string surname, int age, double height, double weight)
        {
            return String.Format("Name: {0}, Surname: {1}, Age: {2}, Height: {3}m, Weight: {4}kg.", name, surname, age, height, weight);
        }

        // Функция для вывода информации со знаком $
        static string InfoInterpolation(string name, string surname, int age, double height, double weight)
        {
            return $"Name: {name},  surname: {surname},  age: {age},  height: {height}m,  weight: {weight}kg.";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            // Вызов функций

            Console.WriteLine(Info(name, surname, age, height, weight));
            Console.ReadLine();
            Console.WriteLine(InfoFormat(name, surname, age, height, weight));
            Console.ReadLine();
            Console.WriteLine(InfoInterpolation(name, surname, age, height, weight));
            Console.ReadLine();

        }
    }
}
#endregion

#region IBM

/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
где m — масса тела в килограммах, h — рост в метрах.*/

namespace ConsoleApp1
{
    class Program
    {
        static double IMB(double height, double weight)
        {
            return weight / (height * height);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш вес: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Индекс массы тела равен: {IMB(height, weight)}");
            Console.ReadLine();

        }
    }
}
#endregion

#region Coordinates

/* Написать программу, которая подсчитывает расстояние между точками с координатами 
x1, y1 и x2, y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

namespace Coordinates
{

    class Program
    {
        // Метод для рассчета расстония между точками
        static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x1 и y1 для точки A: ");
            string s1 = Console.ReadLine();
            string[] values1 = s1.Split(' ');
            int x1 = int.Parse(values1[0]);
            int y1 = int.Parse(values1[1]);
            Console.WriteLine($"Координаты точки А[{x1}; {y1}]");

            Console.WriteLine("Введите координаты x2 и y2 для точки B: ");
            string s2 = Console.ReadLine();
            string[] values2 = s2.Split(' ');
            int x2 = int.Parse(values2[0]);
            int y2 = int.Parse(values2[1]);
            Console.WriteLine($"Координаты точки B[{x2}; {y2}]");

            double line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками равно: {line.ToString("F2")}");

            // Вызов функции расчета расстояния
            Console.WriteLine($"Расстояние между точками, вычисленное по методу Distance, равно: { Distance(x1, y1, x2, y2).ToString("F2")}");
            Console.ReadLine();
        }
    }
}
#endregion

#region Change Value

/* Написать программу обмена значениями двух переменных:
  a) с использованием третьей переменной */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter firsst number: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"Original x={x}, y={y}");

        int tmp = x;
        x = y;
        y = tmp;
        Console.WriteLine($"Exchanged x={x}, y={y}");
    }

}

#endregion

#region PersonalData

namespace PersonalData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 12);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Анна Гусак, Лондон.");
            Console.ReadLine();
        }
    }
}
#endregion


