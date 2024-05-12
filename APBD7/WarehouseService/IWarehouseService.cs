using APBD7.Models;

namespace APBD7.WarehouseService;

public interface IWarehouseService
{
    public Task<int> AddProductToWarehouse(WarehouseRequest request);

}