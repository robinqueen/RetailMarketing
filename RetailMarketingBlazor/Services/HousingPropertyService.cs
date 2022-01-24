using RetailMarketing.Models.APIModels;
using System.Net.Http;
using System.Text.Json;

namespace RetailMarketingBlazor.Services
{
    public class HousingPropertyService :IHousingPropertyService
    {
        private readonly HttpClient httpClient;

        public HousingPropertyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<HousingProperty>> GetHousingProperties()
        {
            List<HousingProperty> housingProperties = new List<HousingProperty>();
            try
            {
                var apiResponse = await httpClient.GetStreamAsync($"https://apifreelance.azurewebsites.net/HousingProperty/GetAllHousingProperties");
                var response = await JsonSerializer.DeserializeAsync<List<HousingProperty>>
                                    (apiResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

                if(response is null)
                {
                    response = new List<HousingProperty>();
                }

                return response;
            }
            catch
            {
                throw;
            }

        }

        public Task<List<HousingProperty>> GetHousingPropertiesByType(string type)
        {
            throw new NotImplementedException();
        }
    }
}
