namespace PersonalDataWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "LastName";
            dataGridView1.Columns[2].Name = "PhoneNumber";
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "LastName";
            dataGridView2.Columns[2].Name = "PhoneNumber";

        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(gender)));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            string userinput = textBox3.Text;
            if (!PhoneNumber.IsValid(userinput))
            {
                MessageBox.Show("Your number is not valid!");
                textBox3.Clear();
            }
            else
            {
                string userinput2 = textBox4.Text;
                int n;
                bool isnumber = int.TryParse(userinput2, out n);
                if (isnumber == false)
                {
                    MessageBox.Show("You should only use numbers for your NC");
                    textBox4.Clear();
                }
                else
                {
                    if (userinput.StartsWith("+"))
                    {
                        userinput = userinput.Remove(0, 2);
                        userinput = userinput.Replace('8', '0');
                        MessageBox.Show($"FullName={textBox1.Text}{textBox2.Text},PhoneNumber={userinput},NationalCode={textBox4.Text},Gender={comboBox1.SelectedItem}");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();

                    }
                    else
                    {
                        MessageBox.Show($"FullName={textBox1.Text}{textBox2.Text},PhoneNumber={textBox3.Text},NationalCode={textBox4.Text},Gender={comboBox1.SelectedItem}");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();

                    }
                }

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
            }
            else if (checkBox1.Checked == false)
            {
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
            }
        }


        public void button3_Click(object sender, EventArgs e)
        {


        }
        public void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBox3.Text;
            if (userinput.StartsWith("+"))
            {
                userinput = userinput.Remove(0, 2);
                userinput = userinput.Replace('8', '0');
            }
                string userinput2 = textBox4.Text;
            int n;
            bool isnumber = int.TryParse(userinput2, out n);
            if (checkBox1.Checked == true && PhoneNumber.IsValid(textBox3.Text) && isnumber == true)
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, userinput);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                checkBox1.Checked = false;

            }
            else if (PhoneNumber.IsValid(textBox3.Text) && isnumber == true && checkBox1.Checked == false)
            {
                dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, userinput);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                checkBox1.Checked = false;
            }
            else
            {
                MessageBox.Show("One of your entered is not valid! check again!");
            }


        }
    }
}