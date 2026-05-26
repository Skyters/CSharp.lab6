using static CSharp.lab6.Particle;

namespace CSharp.lab6
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();

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

            emitter.UpdateState(); // каждый тик обновляем систему

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
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }
    }
}
