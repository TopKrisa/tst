namespace tst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var point1 = new Point(textBox1.Text.ToInt(), textBox2.Text.ToInt());
                var point2 = new Point(textBox3.Text.ToInt(), textBox4.Text.ToInt());
                label3.Text =  CheckDots(point1, point2) == true ?  "Точки в одной четверти" : "Точки не в одной четверти";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private bool CheckDots(Point First, Point Second)
        {
            var x1 = First.X;
            var y1 = First.Y;
            var x2 = Second.X;
            var y2 = Second.Y;

            if (x1 < 0 && x2 < 0)
            {
                if (y1 < 0 && y2 < 0)
                {
                    return true;
                }
            }

            if (x1 > 0 && x2 > 0)
            {
                if (y1 > 0 && y2 > 0)
                {
                    return true;
                }
            }

            if (x1 < 0 && x2 < 0)
            {
                if (y1 > 0 && y2 > 0)
                {
                    return true;
                }
            }

            if (x1 > 0 && x2 > 0)
            {
                if (y1 < 0 && y2 < 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label3.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}