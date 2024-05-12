using APBD7.Models;
using APBD7.WarehouseService;
using Microsoft.AspNetCore.Mvc;

namespace APBD7.Properties;
[ApiController]
[Route("[controller]")]
public class WarehouseController : ControllerBase
{
    private readonly IWarehouseService _warehouseService;

    public WarehouseController(IWarehouseService warehouseService)
    {
        _warehouseService = warehouseService;
    }

    [HttpPost]
    public async Task<IActionResult> AddProductToWarehouse(WarehouseRequest request)
    {
        int id = await _warehouseService.AddProductToWarehouse(request);
        return Ok("Added id: " + id);
    }
}