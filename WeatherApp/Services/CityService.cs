using System.Text.Json.Serialization;

public class MockCityService : ICityService
{
    // Load mock data from files or resources
    private readonly Dictionary<int, List<City>> _citiesByCountry;

    public MockCityService()
    {
        string jsonString = File.ReadAllText("cities.json");
        var cities = JsonConverter.DeserializeObject<List<City>>(jsonString);
        _citiesByCountry = cities.GroupBy(c => c.CountryId)
                                 .ToDictionary(g => g.Key, g => g.ToList());
    }

    public Task<List<City>> GetCitiesByCountryIdAsync(int countryId)
    {
        if (_citiesByCountry.TryGetValue(countryId, out var cities))
        {
            return Task.FromResult(cities);
        }
        return Task.FromResult(new List<City>());
    }
}

