using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudApplicationDemo
{
    public partial class Dashboard : Form
    {
        private List<Person> people = new List<Person>();   

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        public void UpdateBinding()
        {
            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(txtLastName.Text);

            UpdateBinding();                            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(txtFName.Text, txtLName.Text, txtEmail.Text, txtPhoneNum.Text);

            txtFName.Text = txtLName.Text = txtEmail.Text = txtPhoneNum.Text = "";
        }
    }
}
