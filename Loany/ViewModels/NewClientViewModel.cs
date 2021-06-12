using Loany.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Loany.ViewModels
{
    public class NewClientViewModel : BaseViewModel
    {
        string name, phone, address;

        public string Name { get => name; set => SetProperty(ref name, value);}
        public string Phone { get => phone; set => SetProperty(ref phone, value);}
        public string Address { get => address; set => SetProperty(ref address, value); }

        public AsyncCommand SaveCommand { get; }

        IClientService iClientService;

        public NewClientViewModel()
        {
            SaveCommand = new AsyncCommand(Save);
            iClientService = DependencyService.Get<IClientService>();
        }

        async Task Save()
        {
           if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || 
                string.IsNullOrWhiteSpace(address))
            {
                return;
            }

            await iClientService.AddClient(name, phone, address);

            await Shell.Current.GoToAsync("..");
        }
    }
}
