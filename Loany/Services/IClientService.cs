using Loany.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Loany.Services
{
    public interface IClientService
    {
        Task AddClient(string name, string phone, string address);
        Task<IEnumerable<Client>> GetAllClient();
        Task<Client> GetClient(int id);
        Task RemoveClient(int id);

        

       
    }
}
