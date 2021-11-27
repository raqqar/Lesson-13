using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    ////Задан класс Building, который описывает здание.Класс содержит следующие элементы:
    ////    адрес здания;
    ////    длина здания;
    ////    ширина здания;
    ////    высота здания.
    //// В классе Building нужно реализовать следующие методы:
    ////    конструктор с 4 параметрами;
    ////    свойства get/set для доступа к полям класса;
    ////    метод Print(), который выводит информацию о здании.
    //// Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.В классе MultiBuilding реализовать следующие элементы:
    ////    конструктор с 5 параметрами – реализует вызов конструктора базового класса;
    ////    свойство get/set доступа к внутреннему полю класса;
    ////    метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
    ////Класс MultiBuilding сделать таким, что не может быть унаследован.
    class Program
    {
        static void Main(string[] args)
        {
            string A = "Москва ул. Улиц д.18";
            int L = 10;
            int W = 20;
            int H = 5;
            int F = 2;

            Building building = new Building(A, L, W, H);
            building.Print();

            MultiBuilding multiBuilding = new MultiBuilding(A, L, W, H, F);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    public class Building
    {
        private int height;
        private int length;
        private int width;

        public string Adress { get; set; }
        public int Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Значение длины должно быть больше 0\n ");
                }
            }
            get
            {
                return length;
            }
        }
        public int Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Значение ширины должно быть больше 0\n ");
                }
            }
            get
            {
                return width;
            }
        }
        public int Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Значение высоты должно быть больше 0\n ");
                }
            }
            get
            {
                return height;
            }
        }



        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Информация о здании:\nвысота здания : {0}\nширина здания : {1}\nдлина здания : {2}\nадрес здания : {3}", Height, Width, Length, Adress);
            return;
        }
    }
    sealed class MultiBuilding : Building
    {
        private int floors;
        public int Floors
        {
            set
            {
                if (value > 0)
                {
                    floors = value;
                }
                else
                {
                    Console.WriteLine("Значение этажности должно быть больше 0\n ");
                }
            }
            get
            {
                return floors;
            }
        }
        public MultiBuilding(string adress, int length, int width, int height, int floors) : base (adress, length, width, height)

        {
            Floors = floors;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("этажность здания :{0} \n",floors);
        }
    }

   
}
