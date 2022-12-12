using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{

    public partial class AddToList : Form
    {
        const string path = "C:\\Users\\endespair\\Desktop\\Lab4\\MyLab4\\LabaOOP4\\WinFormsApp1TXT.json";
        public Software software { get; set; } = new Software();
        MainList form1 = new MainList();
        public AddToList()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            software.name = textBox1.Text;
            software.annotation = textBox2.Text;
            software.type = textBox3.Text;
            software.version = textBox4.Text;
            software.author = textBox5.Text;
            software.usage = textBox6.Text;
            software.distribution = textBox7.Text;
            form1.facultysoft.softwarelisting.Add(software);

            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
