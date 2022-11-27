using Lyricist.View;
using Lyricist.ViewModel;

namespace Lyricist;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		DependencyService.Register<ApiDataStore>();
		MainPage = new NavigationPage( new HomePage());
	}
}
