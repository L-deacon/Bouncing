namespace Bouncing
{
    public partial class Form1 : Form
    {
        private Body body = new Body(100, 100);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            body.Draw(e.Graphics);
        }
    }
}
