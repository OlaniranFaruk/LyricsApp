using Lyricist.Model;
using Lyricist.ViewModel;

namespace Lyricist.View;

public partial class DetailsPage : ContentPage
{
	DetailsPageViewModel DPVM;
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
        await Navigation.PopAsync();
    }
    

}