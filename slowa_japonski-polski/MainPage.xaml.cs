
namespace slowa_japonski_polski {
    public partial class MainPage : ContentPage {

        public MainPage() {
            InitializeComponent();
        }


        private async void buttonLogowanie(object sender, EventArgs e) {
            await Navigation.PushModalAsync(new PageLogowanie());
        }

        private async void buttonRejestracja(object sender, EventArgs e) {
            await Navigation.PushModalAsync(new PageRejestracja());

        }
    }

}
