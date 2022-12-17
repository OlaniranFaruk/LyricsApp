using Lyricist.Model;
using Lyricist.ViewModel;

namespace Lyricist.View;

public partial class NewMusicPage : ContentPage
{
	NewMusicPageViewModel NMVM;
	HomePageViewModel HPVM;
    public NewMusicPage()
	{
		InitializeComponent();
		NMVM= new NewMusicPageViewModel();	
		NMVM.PageTitle = "Add new music";

        BindingContext = NMVM;
	}
	public async void newMusic(object sender, EventArgs args)
	{
		
        await NMVM.addNewMusic();

	}
}