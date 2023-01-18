using Switch_Bug.ViewModels;

namespace Switch_Bug;

public partial class BookPage : ContentPage
{
	public BookPage(BookPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
