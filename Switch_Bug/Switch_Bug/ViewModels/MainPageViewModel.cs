using System;
using System.Windows.Input;

namespace Switch_Bug.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel()
		{

		}

        public ICommand ClickCommand { get { return new Command(ButtonCliked); } }

        private async void ButtonCliked()
        {
            await Shell.Current.GoToAsync(nameof(HomePage), false);
        }
    }
}

