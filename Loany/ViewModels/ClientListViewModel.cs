using Loany.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loany.ViewModels
{
    public class ClientListViewModel : BaseViewModel
    {

        public ObservableRangeCollection<Client> ClientList { get; set; }


        public Command FillClientCommand { get; }

        public ClientListViewModel()
        {

            ClientList = new ObservableRangeCollection<Client>();

            FillClientCommand = new Command(FillClientList);

            FillClientList();
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

        }

    }
}
