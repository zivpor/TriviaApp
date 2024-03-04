using TriviaApp.ViewModel;

namespace TriviaApp.View;

public partial class BestScoresPage : ContentPage
{
	public BestScoresPage(BestScoresPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}