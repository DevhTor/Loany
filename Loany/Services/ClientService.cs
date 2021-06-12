using Loany.Models;
using Loany.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly:Dependency(typeof(ClientService))]
namespace Loany.Services 
{
    public class ClientService : IClientService
    {
        SQLiteAsyncConnection db;
        
        async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Client>();
        }

        public async Task AddClient(string name, string phone, string address)
        {
            await Init();

            var client = new Client
            {
                Name = name,
                Phone = phone,
                Address = address
            };

            //var id = await db.InsertAsync(coffee);
            await db.InsertAsync(client);
        }

        public async Task RemoveClient(int id)
        {

            await Init();

            await db.DeleteAsync<Client>(id);
        }

        public async Task<IEnumerable<Client>> GetAllClient()
        {
            await Init();

            var client = await db.Table<Client>().ToListAsync();
            return client;
        }

        public async Task<Client> GetClient(int id)
        {
            await Init();

            var client = await db.Table<Client>()
                .FirstOrDefaultAsync(c => c.Id == id);

            return client;
        }

    }
}
