using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPP
{
    public partial class Form1 : Form
    {
        string name;
        string age;
        string gender;
        //List<User> userList;
        public Form1()
        {
            InitializeComponent();
            //userList = new List<User>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            age = textBox2.Text;
            gender = textBox3.Text;

            if (name != "" && age != "")
            {
                User user = new User() { Name = name, Age = Convert.ToInt32(age), Gender=gender };
                listBox1.Items.Add(user);
            }
        }
    }
}
