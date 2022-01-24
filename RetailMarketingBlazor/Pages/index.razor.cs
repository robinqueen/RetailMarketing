using Microsoft.AspNetCore.Components;
using RestSharp;
using RetailMarketing.Models.APIModels;
using RetailMarketingBlazor.Classes.Helper;
using RetailMarketingBlazor.Services;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetailMarketingBlazor.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IHousingPropertyService HousingPropertyService { get; set; }

        private List<HousingProperty> housingProperties = new List<HousingProperty>();

        bool loadingProperties = true;
        protected override async Task OnInitializedAsync()
        {
            
            housingProperties = await HousingPropertyService.GetHousingProperties();
            if(housingProperties is null)
            {
                //service wasn't available, data wasn't returned..
            }

            foreach(var housingProp in housingProperties)
            {
                if (housingProp.MainImage is null || housingProp.MainImage.Length == 0)
                {
                    var imageFile = housingProp.HouseImages.FirstOrDefault(x => x.Type == HouseImages.ImageLocationType.Main).ImageFile;
                    if (imageFile is null || imageFile.Length == 0)
                    {
                        //set to some genric stock photo as house unavailable
                        imageFile = Array.Empty<byte>();
                    }
                    else
                    {
                        housingProp.MainImage = imageFile;
                    }

                }
            }
            loadingProperties = false;


        }

       
    }
}
