using APBD7.Models;

namespace APBD7.WarehouseRepository;

public interface IWarehouseRepository
{
    public Task<int> AddProductToWarehouse(WarehouseRequest request);
    Task<bool> CheckProductExists(int id);
    Task<bool> CheckWarehouseExists(int id);
    Task<bool> CheckOrderExists(int id, int amount, DateTime createdAt);
    Task<bool> IsFulfilled(int id);

}