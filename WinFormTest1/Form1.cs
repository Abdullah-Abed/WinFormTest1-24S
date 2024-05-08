namespace WinFormTest1
{
    public partial class Form1 : Form
    {
        TextBox[] textBoxes = new TextBox[4];
        public Form1()
        {
            InitializeComponent();

            textBoxes[0] = textBox1;
            textBoxes[1] = textBox2;
            textBoxes[2] = textBox3;
            textBoxes[3] = textBox4;

            button1 = ButtonClockwise_Click
            button2 = ButtonCounterClockwise_Click
        }  


        private void ButtonClockwise_Click(object sender, EventArgs e)
    {
        RotateNumbersClockwise();
    }

    private void ButtonCounterClockwise_Click(object sender, EventArgs e)
    {
        RotateNumbersCounterClockwise();
    }

    private void RotateNumbersClockwise()
    {
        string temp = textBoxes[3].Text;
        for (int i = 3; i > 0; i--)
        {
            textBoxes[i].Text = textBoxes[i - 1].Text;
        }
        textBoxes[0].Text = temp;
    }

    private void RotateNumbersCounterClockwise()
    {
        string temp = textBoxes[0].Text;
        for (int i = 0; i < 3; i++)
        {
            textBoxes[i].Text = textBoxes[i + 1].Text;
        }
        textBoxes[3].Text = temp;
    }


}
}
