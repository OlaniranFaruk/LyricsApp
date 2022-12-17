using Lyricist.Model;
using Lyricist.ViewModel;

namespace Lyricist.View;

public partial class DetailsPage : ContentPage
{
	DetailsPageViewModel DPVM;
	HomePageViewModel HPVM;
	Music toBeDeleted;
    public DetailsPage(Music m)
	{
		InitializeComponent();
		toBeDeleted = m as Music;
		DPVM = new DetailsPageViewModel();
		DPVM.PageTitle = "Lyrics page";

		
	}
	public async void deleteMusic(object sender, EventArgs args)
	{
		DPVM.removeMusic(toBeDeleted);
        await DPVM.DataStore.GetMusicListAsync();
        await DPVM.DataStore.GetAllUniqueGenre();
        await Navigation.PopAsync();
    }
    

}