using Lyricist.Model;
using Lyricist.ViewModel;
using System.Linq;

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
        await HVM.GetDataAsync();
        await HVM.GetGenreListAsync();
        IsBusy = false;
    }

    async void OnGenre_SelectedIndexChanged(object sender, EventArgs e)
    {

        var picker = (Picker)sender;
        String selectedGenre;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            //first index is reserved to return back all
            if(selectedIndex == 0)
            {
                await HVM.GetDataAsync();
                return;
            }
            await HVM.GetDataAsync();
            selectedGenre = picker.Items[selectedIndex];
            List<Music> genreEditedList = HVM.MusicList.Where(m => m.Genre.Equals(selectedGenre)).ToList<Music>();
            HVM.MusicList.Clear();
            foreach (var music in genreEditedList)
            {
                HVM.MusicList.Add(music);
            }
        }
        else
        {
            await HVM.GetDataAsync();
        }
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