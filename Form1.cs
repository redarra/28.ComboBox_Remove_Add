namespace _28.ComboBox_Remove_Add
{
    public partial class Form1 : Form
    {
        String action = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (action != "")
            {
                if (action == "Remove")
                {
                    if (comboBox1.Text == "") { 
                        MessageBox.Show("No profession was selected for removal!"); }
                    else { 
                        comboBox1.Items.Remove(comboBox1.SelectedItem); }
                }
                else if (action == "Add")
                {
                    if (textBox1.Text == "") { 
                        MessageBox.Show("No item was entered into the text area to be added!"); }
                    else { 
                        comboBox1.Items.Add(textBox1.Text);
                        textBox1.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("No action was selected!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            action = radioButton1.Text;
            textBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            action = radioButton2.Text;
            textBox1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}