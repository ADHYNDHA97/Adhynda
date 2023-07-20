namespace Adhynda;

public partial class SIgnUpPage : ContentPage
{
	public SIgnUpPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		Navigation.PushAsync (new LoginPage());
    }
}