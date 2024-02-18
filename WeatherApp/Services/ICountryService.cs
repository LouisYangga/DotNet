public interface ICountryService
{
    Task<List<Country>> GetAllCountriesAsync();
}
