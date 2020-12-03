using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AccelaApp
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        Person person = new Person();
        Address address = new Address();

        #region onClick Events
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            person.AddPerson(FirstNameTextBox.Text, LastNameTextBox.Text);
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            address.AddAddress(AddressPersonIDTextBox.Text, StreetTextBox.Text, CityTextBox.Text, StateTexBox.Text, PostalCodeTextBox.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            person.DeletePerson(IdTextBox.Text);
        }

        private void btnListPersons_Click(object sender, EventArgs e)
        {
            PersonListView.Items.Clear();
            PersonListView.Columns.Clear();
            var people = person.ListPersons();

            PersonListView.View = View.Details;
            PersonListView.GridLines = true;
            PersonListView.FullRowSelect = true;

            //Add column header
            PersonListView.Columns.Add("ID", 100);
            PersonListView.Columns.Add("First Name", 100);
            PersonListView.Columns.Add("Last Name", 100);

            //Add items in the listview
            string[] array = new string[3];
            ListViewItem itm;
            foreach (var person in people)
            {
                array[0] = person.PERSON_ID.ToString();
                array[1] = person.FIRST_NAME;
                array[2] = person.LAST_NAME;
                itm = new ListViewItem(array);
                PersonListView.Items.Add(itm);
            }
        }

        private void btnCountPersons_Click(object sender, EventArgs e)
        {
            var noOfPeople = person.CountPerson();
            PersonCountTextBox.Text = noOfPeople;
        }
        #endregion

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            person.EditPerson(Int32.Parse(EditPersonIDTextbox.Text), FirstNameEditTextbox.Text, LastNameEditTextbox.Text);
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            address.DeleteAddress(DeleteAddressTextBox.Text);
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            address.EditAddress(Int32.Parse(EditAddressIdTextbox.Text), EditAddressStreetTextbox.Text, EditAddressCityTextbox.Text, EditAddressStateTextbox.Text, EditAddressPostalCodeTextbox.Text);
        }


        private void btnReadXML_Click(object sender, EventArgs e)
        {
            person.AddPersonXML(XMLReadTextBox.Text);
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accelaDataSet.TBL_PERSON' table. You can move, or remove it, as needed.


        }
    }
}
