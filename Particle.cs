using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab6
{
    class Particle
    {
        public int Radius; // радуис частицы
        public float X; // X координата положения частицы в пространстве
        public float Y; // Y координата положения частицы в пространстве
        
        public float Direction; // направление движения
        public float Speed; // скорость перемещения

        // добавили генератор случайных чисел
        public static Random rand = new Random();

        public Particle()
        {
            Direction = rand.Next(360);
            Speed = 1 + rand.Next(10);
            Radius = 2 + rand.Next(10);
        }
    }

}
