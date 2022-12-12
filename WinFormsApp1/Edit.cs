using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Edit : Form
    {
        public Software editSoft { get; set; } = new Software();
        public int rowIndex { get; set; }
        public SList sofwaring { get; set; }
        public DataGridView dataGrid { get; set; }

        public Edit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            textBoxName.Text = sofwaring.softwarelisting[rowIndex].name;
            textBoxAnnotation.Text = sofwaring.softwarelisting[rowIndex].annotation;
            textBoxType.Text = sofwaring.softwarelisting[rowIndex].type;
            textBoxVersion.Text = sofwaring.softwarelisting[rowIndex].version;
            textBoxAuthor.Text = sofwaring.softwarelisting[rowIndex].author;
            textBoxUsage.Text = sofwaring.softwarelisting[rowIndex].usage;
            textBoxDistribution.Text = sofwaring.softwarelisting[rowIndex].distribution;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string path = "C:\\Users\\endespair\\Desktop\\Lab4\\MyLab4\\LabaOOP4\\WinFormsApp1\\TXT.json";
            string josnFile = File.ReadAllText(path);
            int rowIndex = dataGrid.CurrentCell.RowIndex;

            sofwaring.softwarelisting[rowIndex].name = textBoxName.Text;
            sofwaring.softwarelisting[rowIndex].annotation = textBoxAnnotation.Text;
            sofwaring.softwarelisting[rowIndex].type = textBoxType.Text;
            sofwaring.softwarelisting[rowIndex].version = textBoxVersion.Text;
            sofwaring.softwarelisting[rowIndex].author = textBoxAuthor.Text;
            sofwaring.softwarelisting[rowIndex].usage = textBoxUsage.Text;
            sofwaring.softwarelisting[rowIndex].distribution = textBoxDistribution.Text;
            SHelper.FileSerialize(sofwaring, path);
            dataGrid.DataSource = new BindingList<Software>(sofwaring.softwarelisting);
            Close();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
