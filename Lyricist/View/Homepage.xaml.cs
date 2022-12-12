using Lyricist.Model;
using Lyricist.ViewModel;

namespace Lyricist.View;

public partial class HomePage : ContentPage
{

	HomePageViewModel HVM;
    public HomePage()
	{
		InitializeComponent();
		HVM= new HomePageViewModel();
		HVM.GetDataAsync();
		HVM.GetGenreListAsync();
        HVM.PageTitle = "Music List";
        BindingContext = HVM;
	}
    async void RefreshAsync()
    {
        IsBusy = true;
        //await HVM.GetDataAsync();
        IsBusy = false;
    }


    public async void openNewMusicPage(object sender, EventArgs args)
    {
        await App.Current.MainPage.Navigation.PushAsync(new NewMusicPage());
    }

    async void openLyricsPage(object sender, SelectedItemChangedEventArgs args)
    {
       
        HVM.selectedMusic = args.SelectedItem as Music;
        await App.Current.MainPage.Navigation.PushAsync(new DetailsPage(HVM.selectedMusic)
        {
            BindingContext = HVM.selectedMusic

        });
    }
}