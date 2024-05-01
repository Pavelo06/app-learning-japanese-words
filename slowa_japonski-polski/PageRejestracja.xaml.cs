namespace slowa_japonski_polski;

public partial class PageRejestracja : ContentPage
{
	public PageRejestracja()
	{
		InitializeComponent();
	}

    private async void buttonCreateAccount(object sender, EventArgs e) {
        //validate input

        //go back to main page after succesful account creation
        await Navigation.PopModalAsync();
    }

    private async void buttonReturnToMainPage(object sender, EventArgs e) {
        await Navigation.PopModalAsync();
    }
}