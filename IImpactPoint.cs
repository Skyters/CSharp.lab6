using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab6
{
    public abstract class IImpactPoint
    {
        public float X; // ну точка же, вот и две координаты
        public float Y;

        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }


    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; // сила притяжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                // то притягиваем ее
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }

        public override void Render(Graphics g)
        {
            // окружность
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
            );
        }
    }

    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100; // сила отторжения

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            particle.SpeedX -= gX * Power / r2; // тут минусики вместо плюсов
            particle.SpeedY -= gY * Power / r2; // и тут
        }

        public override void Render(Graphics g)
        {
            // окружность
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 1,
                   Y - Power / 1,
                   Power,
                   Power
            );
        }
    }

    public class BouncePoint : IImpactPoint
    {
        public int Radius = 40; // радиус зоны отражения

        public override void ImpactParticle(Particle particle)
        {
            float dx = particle.X - X;
            float dy = particle.Y - Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);

            // Частица внутри зоны
            if (dist < Radius && dist > 0.001f)
            {
                // Нормаль: от центра к частице
                float nx = dx / dist;
                float ny = dy / dist;

                // Проекция скорости на нормаль
                float dot = particle.SpeedX * nx + particle.SpeedY * ny;

                // Отражаем только если частица летит внутрь (dot < 0)
                if (dot < 0)
                {
                    // v' = v - 2*(v·n)*n
                    particle.SpeedX -= 2 * dot * nx;
                    particle.SpeedY -= 2 * dot * ny;
                }

                // Выталкиваем частицу на границу окружности
                particle.X = X + nx * Radius;
                particle.Y = Y + ny * Radius;
            }
        }

        public override void Render(Graphics g)
        {         
            g.DrawEllipse(new Pen(Color.Yellow), X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }


}
