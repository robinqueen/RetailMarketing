using RetailMarketing.Models.APIModels;

namespace RetailMarketingBlazor.Services
{
    public interface IHousingPropertyService
    {
        Task<List<HousingProperty>> GetHousingProperties();
        Task<List<HousingProperty>> GetHousingPropertiesByType(string type);
    }
}
