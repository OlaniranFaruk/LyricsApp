using Lyricist.ViewModel;

namespace Lyricist.View;

public partial class DetailsPage : ContentPage
{
	BaseViewModel BVM;
    public DetailsPage()
	{
		InitializeComponent();
		BVM = new BaseViewModel();
		BVM.PageTitle = "Lyrics page";
	}

}