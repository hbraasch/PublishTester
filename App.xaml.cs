using SyllablesTrainer.Pages;

namespace PublishTester;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		// MainPage = new AppShell();
        MainPage = new NavigationPage(new StartupPage()) { BarBackgroundColor = Colors.Grey, BarTextColor = Colors.White};
    }
}
