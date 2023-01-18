using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Switch_Bug.ViewModels
{
	public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;
    }
}

