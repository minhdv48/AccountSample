using System.Collections.Generic;
using System.Threading.Tasks;
using SampleDataModel;

namespace SampleDataAccess
{
    public interface IPersistentData
    {
        void AddClient(IClient p);
        void UpdateClient(IClient p);
        void RemoveClient(int clientId);
        Task<List<IClient>> GetClients();
        void AddProduct(DbInitializer p);
        void UpdateProduct(DbInitializer p);
        void RemoveProduct(int productId);
        Task<List<DbInitializer>> GetProducts();
    }
}