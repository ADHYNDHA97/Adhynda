namespace Adhynda;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navPage = new NavigationPage(new LoginPage());

		navPage.BarBackground = Colors.Pink;
		navPage.BarTextColor = Colors.Black;  

		MainPage = navPage;
	}
}
