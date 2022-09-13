namespace Switch_Bug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	// This not works in iOS, works fine in Android
    void toggle2_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
		if (e.Value)
		{
			toggle2.OnColor = Color.FromArgb("#ffa500");
            toggle2.ThumbColor = Color.FromArgb("#512BD4");
        }
		else
		{
            toggle2.OnColor = Color.FromArgb("#969696");
            toggle2.ThumbColor = Color.FromArgb("#DFD8F7");
        }
    }
}


