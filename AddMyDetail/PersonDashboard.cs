using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace AddMyDetail
{
    public partial class PersonDashboard : Form, ISaveAddress
    {


        private BindingList<Address> addresses = new BindingList<Address>();
        public PersonDashboard()
        {
            InitializeComponent();
            AddressListBox.DataSource = addresses;
            AddressListBox.DisplayMember = nameof(Address.FullAddress);
        }

        public void SaveAddress(Address address)
        {
            addresses.Add(address);
        }

        private void AddAddress_Click(object sender, EventArgs e)
        {
            
            AddressEntry addressEntry = new AddressEntry(this);
            addressEntry.Show();


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Age = AgeInput.Text;
            person.Name = NameInput.Text;
            person.Address = addresses.ToList();
            
        }
    }
}
