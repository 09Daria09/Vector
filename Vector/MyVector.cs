using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.1.Члены данных:
Закрытые:
Координата х - 
Координата у - 
Координата z -
Функции - члены:
Конструкторы:
Конструктор по умолчанию
Параметризированный конструктор с одним параметром -
Параметризированный конструктор с тремя параметрами -
Методы:
Метод без входных и выходных параметров:
Ввод вектора - 
Вывод вектора -
Метод только с выходными параметрами:
Возвращает х -
Возвращает у -
Возвращает z -
Возвращает длину вектора -
Определение угла поворота вектора
Метод только с входными параметрами:
Увеличение координат вектора на скаляр -
Уменьшение координат вектора на скаляр - 
Метод с входными и выходными параметрами:
Сложение двух векторов -
Вычитание двух векторов -
Поэлементное умножение двух векторов
Скалярное произведение двух векторов
Определение угла между двумя векторами
Проверка на равенство двух векторов*/


namespace Vector
{   class MyVector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public MyVector(double x, double y, double z):this(y,z)
        {
           this.x = x;
        }
        public MyVector(double y, double z) : this(z)
        {
            this.y = y;
        }
        public MyVector(double z)
        {
            this.z = z;
        }
        public MyVector() 
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public double Init()
        {
            Console.WriteLine($"Введите координату х ->");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите координату y ->");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите координату z ->");
            z = Convert.ToDouble(Console.ReadLine());
            return 0;
        }
        public void Prdouble()
        {
            Console.WriteLine($"Координата х: {x}, y: {y}, z:{z}");
        }
        public double LenghtVector()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public MyVector Increase(double a)
        {
            MyVector dop = new MyVector();
            dop.x += a;
            dop.y += a;
            dop.z += a;
            return dop;
        }
        public MyVector Decrease(double a)
        {
            MyVector dop = new MyVector();
            dop.x += a;
            dop.y += a;
            dop.z += a;
            return dop;
        }
        public MyVector Addition (MyVector b)
        {
            x += b.x;
            y += b.y;
            z += b.z;
            return this;
        }
        public MyVector Subtraction(MyVector b)
        {
            x -= b.x;
            y -= b.y;
            z -= b.z;
            return this;
        }
        public double Multiplication(MyVector b)
        {
            return (x * b.x) + (y * b.y) + (z * b.z);
        }
        public double angle(MyVector a)
        {
            double modA, modB;
            modA = Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2));
            modB = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            return Multiplication(a) / (modA * modB);
        }
        public void Equality(MyVector b)
        {
            if (this == b)
            {
                Console.WriteLine("Both vectors are equal");
            }
            else
            {
                Console.WriteLine("Both vectors are not equal");
            }
        }
    }
}
