public interface ICityService
{
    Task<List<City>> GetCitiesByCountryIdAsync(int countryId);
}