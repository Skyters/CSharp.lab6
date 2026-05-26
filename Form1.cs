namespace CSharp.lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // привязал изображение
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
        }
    }
}
