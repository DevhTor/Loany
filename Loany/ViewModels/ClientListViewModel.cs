using Loany.Models;
using Loany.Views;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Loany.ViewModels
{
    public class ClientListViewModel : BaseViewModel
    {

        public ObservableRangeCollection<Client> ClientList { get; set; }


        
        public AsyncCommand AddNewClientCommand { get; }

        public ClientListViewModel()
        {

            ClientList = new ObservableRangeCollection<Client>();

            
            AddNewClientCommand = new AsyncCommand(AddNewCliente);

            FillClientList();
        }

         async Task AddNewCliente()
        {

            await Shell.Current.GoToAsync(nameof(NewClientPage));
        }

       public void FillClientList()
        {
            ClientList.Add(new Client
            {
                Id = "1",
                Name = "Ramon",
                Phone = "8295262999",
                Address = "Calle 1 esq 2"
            });

            ClientList.Add(new Client
            {
                Id = "2",
                Name = "Pedro",
                Phone = "8295664259",
                Address = "Calle 3 esq 5"
            });

            ClientList.Add(new Client
            {
                Id = "3",
                Name = "Sofia",
                Phone = "8295272999",
                Address = "Calle 1 esq 2"
            });

            ClientList.Add(new Client
            {
                Id = "4",
                Name = "Alejandro",
                Phone = "8294364259",
                Address = "Calle 3 esq 5"
            });

            ClientList.Add(new Client
            {
                Id = "5",
                Name = "Roberto",
                Phone = "8498899939",
                Address = "Calle 1 esq 2"
            });

            ClientList.Add(new Client
            {
                Id = "6",
                Name = "Pepe",
                Phone = "82956653535",
                Address = "Calle 3 esq 5"
            });

            ClientList.Add(new Client
            {
                Id = "7",
                Name = "Steven",
                Phone = "8295253099",
                Address = "Calle 1 esq 2"
            });

            ClientList.Add(new Client
            {
                Id = "8",
                Name = "Raul",
                Phone = "8295650079",
                Address = "Calle 3 esq 5"
            });

        }

    }
}
