using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ribeshanish.Classes;

namespace ribeshanish.forms
{
    public partial class PersonalInfo : Form
    {
        public PersonalInfo()
        {
            InitializeComponent();
            PersonList = new List<Person>();
        }
        public List<Person> PersonList { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            Person p = new Person();


            p.LastName = textBox1.Text;
            p.FirstName = textBox4.Text;
            p.Age = Convert.ToInt32(textBox3.Text);
            p.Address = textBox2.Text;
            p.Phone = textBox5.Text;

            p.City = Convert.ToString(comboBox1.SelectedItem);
            p.DOB = dateTimePicker1.Value;


            if (radioButton1.Checked==true)
            {
                p.Gender = "Male";
            }
            else
            {
                p.Gender = "Female";
            }



            foreach (var item in football.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox c = (CheckBox)item;


                    if (c.Checked == true)

                    {
                        p.Football.Add(c.Text);
                    }
                }
            }



            string filepath = @"d://ribeshanish.json";
            if (File.Exists(filepath))
            {
                string oldata = File.ReadAllText(filepath);
                PersonList = JsonConvert.DeserializeObject<List<Person>>(oldata);
            }            
            PersonList.Add(p);
            string data = JsonConvert.SerializeObject(PersonList);
            File.WriteAllText(@"d://ribeshanish.json", data);

            MessageBox.Show("Saved");

            textBox1.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonList plist = new PersonList();
            plist.ShowDialog();
        }
    }
}
