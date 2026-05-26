using static CSharp.lab6.Emitter;
using static CSharp.lab6.Particle;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CSharp.lab6
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        List<CounterPoint> counterPoints = new List<CounterPoint>();

        GravityPoint point1;
        AntiGravityPoint point2;
        BouncePoint point3;
        BouncePoint point4;
        BouncePoint point5;
        CounterPoint counterPoint;

        public Form1()
        {
            InitializeComponent();

            // привязал изображение
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 0,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // рендер и обновл



            // привязываем гравитоны к полям
            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 200,
                Y = (float)(picDisplay.Height / 1.2),
            };
            point2 = new AntiGravityPoint
            {
                X = picDisplay.Width / 2 - 140,
                Y = picDisplay.Height / 1,
            };
            point3 = new BouncePoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };
            point4 = new BouncePoint
            {
                X = picDisplay.Width / 2 + 150,
                Y = picDisplay.Height / 2,
            };
            point5 = new BouncePoint
            {
                X = picDisplay.Width / 2 - 50,
                Y = picDisplay.Height / 4,

            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);
        }

        private void timer1_Tick(object sender, EventArgs e) // dsdjl xfcnbws
        {

            emitter.UpdateState(); // каждый тик обновляем систему

            lblCount.Text = $"Частиц: {emitter.AliveCount()}";

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // фон
                emitter.Render(g); // рендерим систему
            }

            picDisplay.Invalidate();
        }


        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные для хранения положения мыши
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            point3.X = e.X;
            point3.Y = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpread_Scroll(object sender, EventArgs e)
        {

            emitter.Spreading = tbSpread.Value;
            lblSpread.Text = $"{tbSpread.Value}";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            point1.Power = tbGraviton.Value;
            lblGraviton.Text = $"{tbGraviton.Value}";
        }

        private void tbAntiGraviton_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbAntiGraviton.Value;
            lblAntiGraviton.Text = $"{tbAntiGraviton.Value}";
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            point3.Radius = Math.Clamp(
                point3.Radius + e.Delta / 10,
                0, 200
            );
        }

        private void btnradio1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btnradio1.Checked == true)
            {
                emitter.GravitationY = 1;
            }
            else emitter.GravitationY = 0;
        }

        private void btnradio2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnradio1.Checked == false)
            {
                emitter.GravitationY = 0;
            }
            else emitter.GravitationY = 1;
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // новый счётчик на место клика
                var counter = new CounterPoint { X = e.X, Y = e.Y };
                counterPoints.Add(counter);
                emitter.impactPoints.Add(counter);
            }
            else if (e.Button == MouseButtons.Right)
            {
                // удалить ближайший счётчик к месту клика
                var nearest = counterPoints
                    .OrderBy(c => Math.Pow(c.X - e.X, 2) + Math.Pow(c.Y - e.Y, 2))
                    .FirstOrDefault();

                if (nearest != null)
                {
                    counterPoints.Remove(nearest);
                    emitter.impactPoints.Remove(nearest);
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                if (emitter.impactPoints.Contains(point3))
                    emitter.impactPoints.Remove(point3);
                else
                    emitter.impactPoints.Add(point3);
            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMin = tbSpeed.Value;
            lblSpeed.Text = $"{tbSpeed.Value}";
        }

        private void tbCount_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbCount.Value;
        }

        private void tbLife_Scroll(object sender, EventArgs e)
        {
            emitter.LifeMin = tbLife.Value;
        }

    }
}
