﻿using Switch_Bug.ViewModels;

namespace Switch_Bug;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
