using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AddMyDetail
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent;
        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        
        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Address address = new Address();


            address.City = CityInput.Text;
            address.Street = StreetInput.Text;
            address.Country = CountryInput.Text;
            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
