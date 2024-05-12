using APBD7.Models;
using APBD7.WarehouseRepository;

namespace APBD7.WarehouseService;

public class WarehouseService : IWarehouseService
{
    private readonly IWarehouseRepository _warehouseRepository;
    
    public WarehouseService(IWarehouseRepository warehouseRepository)
    {
        _warehouseRepository = warehouseRepository;
    }

    public async Task<int> AddProductToWarehouse(WarehouseRequest request)
    {
        int insertedId = await _warehouseRepository.AddProductToWarehouse(request);
        return insertedId;
    }
}