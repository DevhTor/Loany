using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Loany.Services
{
    public class ClientService
    {
        SQLiteConnection db;
        
        async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");
        }
    }
}
