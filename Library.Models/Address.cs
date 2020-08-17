namespace Library.Models
{
    public class Address
    {
        public string Street { get; set; }

        public string City {get; set; }

        public string Country{ private get; set; }

        public string FullAddress
        {
            get { return $"{Street} {City}, {Country}"; }
            
        }


    }
}