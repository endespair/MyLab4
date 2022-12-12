using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class MainList : Form
    {
        public SList facultysoft { get; set; } = new SList();
        public DataGridView Grid3 { get; set; }

        const string path = "C:\\Users\\endespair\\Desktop\\Lab4\\MyLab4\\LabaOOP4\\WinFormsApp1\\TXT.json";
        public MainList()
        {
            InitializeComponent();
            timer1.Start();
        }

        private int ticks;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            AddToList form2 = new AddToList();
            form2.ShowDialog();
            facultysoft.softwarelisting.Add(form2.software);
            SHelper.FileSerialize(facultysoft, path); 
            dataGridView1.DataSource = new BindingList<Software>(facultysoft.softwarelisting);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            Edit edit = new Edit();
            edit.rowIndex = dataGridView1.CurrentCell.RowIndex;
            edit.sofwaring = facultysoft;
            edit.dataGrid = dataGridView1;
            edit.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchResult form3 = new SearchResult();
            MainList form1 = new MainList();
            form3.Show();
            SHelper.LinqSort(path, textBox1.Text, textBox2.Text, textBox3.Text);
            
            form3.getGrid().DataSource = new BindingList<Software>(SHelper.LinqSort(path, textBox1.Text, textBox2.Text, textBox3.Text));           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string json = "{\r\n    \"softwarelisting\": [\r\n    {\r\n      \"name\": \"we\",\r\n      \"annotation\": \"we\",\r\n      \"type\": \"we\",\r\n      \"version\": \"we\",\r\n          },\r\n    {\r\n      \"name\": \"we\",\r\n      \"annotation\": \"we\",\r\n      \"type\": \"we\",\r\n      \"version\": \"we\",\r\n          },\r\n    {\r\n      \"name\": \"we\",\r\n      \"annotation\": \"we\",\r\n      \"type\": \"we\",\r\n      \"version\": \"we\",\r\n          }\r\n  ]\r\n}";
            var soft = JsonSerializer.Deserialize<SList>(json);
            dataGridView1.DataSource = new BindingList<Software>(soft.softwarelisting);
        }

        private void button4_Click(object sender, EventArgs e)
        {    
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                    facultysoft.softwarelisting.RemoveAt(row.Index);
            }

            var json = JsonSerializer.Serialize(facultysoft, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(path, json);
            dataGridView1.DataSource = new BindingList<Software>(facultysoft.softwarelisting);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чередниченко Володимир К-27 | 9 варiант");

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
;           ticks++;
            label4.Text = ticks.ToString();
        }
    }
}