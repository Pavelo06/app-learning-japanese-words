namespace slowa_japonski_polski;

public partial class PageMenuZalogowanegoUzytkownia : ContentPage
{
	public PageMenuZalogowanegoUzytkownia()
	{
		InitializeComponent();
	}
    private async void buttonGoToWordSetPage(object sender, EventArgs e) {
		//await Navigation.PushModalAsync(new PageWordCategoryList());
    }

    private async void buttonLogout(object sender, EventArgs e) {
		await Navigation.PopModalAsync();
    }
}