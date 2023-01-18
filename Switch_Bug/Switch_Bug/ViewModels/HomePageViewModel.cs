using System;
using System.Windows.Input;

namespace Switch_Bug.ViewModels
{
	public class HomePageViewModel : ViewModelBase
	{
		public HomePageViewModel()
		{
            WelcomeText = "Welcome to .Net Maui!";
		}

        private string _welcomeText;
        public string WelcomeText
        {
            get { return _welcomeText; }
            set { SetProperty(ref _welcomeText, value); }
        }

        public ICommand ClearCommand { get { return new Command(Clear); } }

        private void Clear()
        {
            WelcomeText = String.Empty;
        }

        public ICommand ShowBookPageCommand { get { return new Command(ShowBookPage); } }

        private async void ShowBookPage()
        {
            await Shell.Current.GoToAsync(nameof(BookPage), false);
        }
    }
}

