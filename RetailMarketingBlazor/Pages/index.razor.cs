using Microsoft.AspNetCore.Components;
using RestSharp;
using RetailMarketing.Models.APIModels;
using RetailMarketingBlazor.Services;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RetailMarketingBlazor.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IHousingPropertyService HousingPropertyService { get; set; }

        private List<HousingProperty> housingProperties = new List<HousingProperty>();

        protected override async Task OnInitializedAsync()
        {
            housingProperties = await HousingPropertyService.GetHousingProperties();
            if(housingProperties is null)
            {
                //service wasn't available, data wasn't returned..
            }
        }

    }
}
