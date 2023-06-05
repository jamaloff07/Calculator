namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        bool oprtr=false;

        double netice = 0;

        string opt="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" || oprtr)
            {
                textBox1.Clear();
            }
            oprtr = false; 

            Button number = (Button)sender;

            textBox1.Text+=number.Text;


        }

        private void button12_Click(object sender, EventArgs e)
        {
            oprtr = true;
            Button buton=(Button)sender;
            string tezeopt = buton.Text;
            label1.Text = label1.Text + "   " + textBox1.Text + " " + tezeopt;


            switch (opt)
            {
                case "+": textBox1.Text = (netice + Double.Parse(textBox1.Text)).ToString();break;
                case "-": textBox1.Text = (netice - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (netice * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (netice / Double.Parse(textBox1.Text)).ToString(); break;

            }
            netice=Double.Parse(textBox1.Text);
            textBox1.Text = netice.ToString();

            opt = tezeopt;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            label1.Text = "";
            opt = "";
            netice = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            oprtr = true;
            switch (opt)
            {
                case "+": textBox1.Text = (netice + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (netice - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (netice * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (netice / Double.Parse(textBox1.Text)).ToString(); break;

            }
            netice = Double.Parse(textBox1.Text);
            textBox1.Text = netice.ToString();

            opt = "";

        }
    }
}