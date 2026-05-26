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

        public void UpdateState() // обновления состояния системы
        {
            foreach (var point in impactPoints)
            {
                point.ImpactParticle(particle);
            }

            // генерирую 500 частиц
            for (var i = 0; i < 500; ++i)
            {
                if (particles.Count < 500) // пока частиц меньше 500 генерируем новые
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
                    // добавляю список
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

    }

}
