using CommunityToolkit.Mvvm.ComponentModel;

namespace SoUs.CareApp.viewModels
{

    public partial class BaseViewModel : ObservableObject
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
