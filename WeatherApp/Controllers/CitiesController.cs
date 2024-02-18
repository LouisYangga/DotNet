using Microsoft.AspNetCore.Mvc;

public class CitiesController : Controller
{
    private readonly ICityService _cityService;

    public CitiesController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet("{countryId}")] // Route parameter for country ID
    public async Task<IActionResult> GetCitiesByCountryId(int countryId)
    {
        try
        {
            var cities = await _cityService.GetCitiesByCountryIdAsync(countryId);
            return Ok(cities);
        }
        catch (Exception ex)
        {
            // Handle exception
            return StatusCode(500, "Error retrieving cities.");
        }
    }
}
