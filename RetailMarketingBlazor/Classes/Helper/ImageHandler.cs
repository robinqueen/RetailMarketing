using RetailMarketing.Models.APIModels;

namespace RetailMarketingBlazor.Classes.Helper
{
    public class ImageHandler
    {
        public string byteArrayToString(byte[] byteArrayIn)
        {
            var base64 = Convert.ToBase64String(byteArrayIn);
            return String.Format("data:image/gif;base64,{0}", base64);
            
        }

        public byte[] stringToByteArray(string str)
        {
            return Convert.FromBase64String(str);
        }

        /// <summary>
        /// Main,
        /// Yard,
        /// Porch,
        /// Deck,
        /// Livingroom,
        /// Bedroom,
        /// Office,
        /// Kitchen,
        /// Utility,
        /// MasterBedroom,
        /// Bathroom,
        /// MasterBathroom,
        /// Other
        /// </summary>
        /// <param name="houseImage"></param>
        public HouseImages.ImageLocationType DetermineImageType(string filePath)
        {
            if (filePath.Contains("Main"))
            {
                return HouseImages.ImageLocationType.Main;
            }
            else if (filePath.Contains("Yard"))
            {
                return HouseImages.ImageLocationType.Yard;
            }
            else if (filePath.Contains("Deck"))
            {
                return HouseImages.ImageLocationType.Deck;
            }
            else if (filePath.Contains("Livingroom"))
            {
                return HouseImages.ImageLocationType.Livingroom;
            }
            else if (filePath.Contains("Bedroom"))
            {
                return HouseImages.ImageLocationType.Bedroom;
            }
            else if (filePath.Contains("Office"))
            {
                return HouseImages.ImageLocationType.Office;
            }
            else if (filePath.Contains("Kitchen"))
            {
                return HouseImages.ImageLocationType.Kitchen;
            }
            else if (filePath.Contains("Utility"))
            {
                return HouseImages.ImageLocationType.Utility;
            }
            else if (filePath.Contains("MasterBedroom"))
            {
                return HouseImages.ImageLocationType.MasterBedroom;
            }
            else if (filePath.Contains("Bathroom"))
            {
                return HouseImages.ImageLocationType.Bathroom;
            }
            else if (filePath.Contains("MasterBathroom"))
            {
                return HouseImages.ImageLocationType.MasterBathroom;
            }
            else if (filePath.Contains("Other"))
            {
                return HouseImages.ImageLocationType.Other;
            }
            else
            {
                return HouseImages.ImageLocationType.Other;
            }
        }


    }
}
