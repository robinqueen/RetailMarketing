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
                return await JsonSerializer.DeserializeAsync<List<HousingProperty>>
                                    (apiResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Task<List<HousingProperty>> GetHousingPropertiesByType(string type)
        {
            throw new NotImplementedException();
        }
    }
}
