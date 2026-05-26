using System;
using System.Collections.Generic;
using System.Text;
using static CSharp.lab6.Particle;

namespace CSharp.lab6
{
    public class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();// тут буду хранится точки притяжения
        public int MousePositionX;
        public int MousePositionY;
        public float GravitationX = 0;
        public float GravitationY = 0;

        public int ParticlesCount = 500;



        public void UpdateState() // обновления состояния системы
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; // уменьшаю здоровье
                                    // если здоровье кончилось
                if (particle.Life < 0)
                {
                    ResetParticle(particle);
                }
                else
                {
                    // каждая точка по-своему воздействует на вектор скорости
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    // гравитация воздействует на вектор скорости, поэтому пересчитываем его
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    // храним вектор скорости в явном виде и его не надо пересчитывать
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            // генерирую 500 частиц
            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < ParticlesCount) // пока частиц меньше 500 генерируем новые
                {
                    var particle = new ParticleColorful();
                    // ну и цвета меняем
                    particle.FromColor = Color.Yellow;
                    particle.ToColor = Color.FromArgb(0, Color.Magenta);

                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    /*// переношу частицы в центр изображения
                    particle.X = picDisplay.Image.Width / 2;
                    particle.Y = picDisplay.Image.Height / 2;
                    */

                    ResetParticle(particle);

                    particles.Add(particle);
                }
                else
                {
                    break; // а если частиц уже 500 штук, то ничего не генерирую
                }
            }

        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            // рисую точки притяжения красными кружочками
            foreach (var point in impactPoints)
            {
                ; point.Render(g);
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            // восстанавливаю здоровье
            particle.Life = 20 + Particle.rand.Next(100);

            // новое начальное расположение частицы — это то, куда указывает курсор
            particle.X = MousePositionX;
            particle.Y = MousePositionY;
            /*// перемещаю частицу в центр
            particle.Direction = Particle.rand.Next(360);
            particle.Speed = 1 + Particle.rand.Next(10);
            particle.Radius = 2 + Particle.rand.Next(10);
            */

            /* сброс состояния частицы */
            var direction = (double)Particle.rand.Next(360);
            var speed = 1 + Particle.rand.Next(10);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = 2 + Particle.rand.Next(10);
        }

        public class TopEmitter : Emitter
        {
            public int Width; // длина экрана

            public override void ResetParticle(Particle particle)
            {
                base.ResetParticle(particle); // вызываем базовый сброс частицы, там жизнь переопределяется и все такое

                // а теперь тут уже подкручиваем параметры движения
                particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
                particle.Y = 0;  // ноль -- это верх экрана 

                particle.SpeedY = 1; // падаем вниз по умолчанию
                particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
            }
        }
    }

}
