namespace slowa_japonski_polski;

public partial class PageLogowanie : ContentPage
{
	public PageLogowanie()
	{
		InitializeComponent();
	}

    private async void buttonZaloguj(object sender, EventArgs e) {
        /* 
         sprawdzenie prawid�owych danych logowania itd.
         */

        //je�li prawid�owe dane, przejd� do nowego Page'a
        await Navigation.PushModalAsync(new PageMenuZalogowanegoUzytkownia());
    }

    private async void buttonPowrotDoMainPage(object sender, EventArgs e) {
        await Navigation.PopModalAsync();
    }
}