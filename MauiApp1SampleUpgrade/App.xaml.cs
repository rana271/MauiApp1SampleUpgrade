using UpgradeXamarinForms.Views;

namespace MauiApp1SampleUpgrade;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AboutPage();
	}
}
