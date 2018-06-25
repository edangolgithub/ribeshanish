using Newtonsoft.Json;
using ribeshanish.Classes;
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

namespace ribeshanish.forms
{
    public partial class PersonList : Form
    {
        public List<Person> PersonLists { get; set; }
        public PersonList()
        {
            InitializeComponent();
            PersonLists = new List<Person>();
            string filepath = @"d://ribeshanish.json";
            if (File.Exists(filepath))
            {
                string oldata = File.ReadAllText(filepath);
                PersonLists = JsonConvert.DeserializeObject<List<Person>>(oldata);
                dataGridView1.DataSource = PersonLists;
            }
        }
    }
}
