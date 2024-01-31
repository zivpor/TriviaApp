using TriviaApp.ViewModel;

namespace TriviaApp.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        this.BindingContext = new LoginPageViewModel();

    }
}