namespace RetailMarketing.Models.APIModels
{
    public class HousingProperty
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string PropertyType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public int LeaseLength { get; set; }
        public string LeaseType { get; set; }
    }
}
