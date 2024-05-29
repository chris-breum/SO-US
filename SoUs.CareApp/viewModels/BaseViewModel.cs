using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.CareApp.viewModels
{

    public partial class BaseViewModel: ObservableObject
    {
        public BaseViewModel()
        {

        }
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool _isBusy;

        [ObservableProperty]
        private string _title;
       
        public bool IsNotBusy => !IsBusy;


    }
}
