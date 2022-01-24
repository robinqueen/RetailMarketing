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

        public byte[] MainImage { get; set; }

        
        public List<HouseImages> HouseImages { get; set; } = new List<HouseImages>();

    }

    public class HouseImages
    {
        public int HouseID { get; set; }

        public ImageLocationType Type { get; set; }
        public byte[] ImageFile { get; set; } 

        public string ImageFilePath { get; set; }
        
        public enum ImageLocationType
        {
            Main,
            Yard,
            Porch,
            Deck,
            Livingroom,
            Bedroom,
            Office,
            Kitchen,
            Utility,
            MasterBedroom,
            Bathroom,
            MasterBathroom,
            Other

        }
    }

    
}
