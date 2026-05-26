using static CSharp.lab6.Particle;

namespace CSharp.lab6
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        // добавляем переменные для хранения положения мыши
        private int MousePositionX = 0;
        private int MousePositionY = 0;

        public Form1()
        {
            InitializeComponent();

            // привязал изображение
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }

        private void timer1_Tick(object sender, EventArgs e) // dsdjl xfcnbws
        {

            UpdateState(); // каждый тик обновляем систему

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // фон
                Render(g); // рендерим систему
            }

            picDisplay.Invalidate();
        }


        private void UpdateState() // обновления состояния системы
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; // уменьшаю здоровье
                                    // если здоровье кончилось
                if (particle.Life < 0)
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
                else
                {
                    // храним вектор скорости в явном виде и его не надо пересчитывать
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
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

        private void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные для хранения положения мыши
            MousePositionX = e.X;
            MousePositionY = e.Y;
        }
    }
}
