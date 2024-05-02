using Plugin.Maui.Audio;

namespace slowa_japonski_polski;

public partial class PageStartedSession : ContentPage
{
    private readonly IAudioManager audioManager;

    List<WordClass> currentWordList;
	public PageStartedSession(List<WordClass> wordList, IAudioManager audioManager)
	{
		InitializeComponent();
        this.audioManager = audioManager;

		currentWordList = wordList;

		//first word
		goToNextWord();   
    }

    Random random = new Random();
	int idWordToGuess = 0;

    IAudioPlayer player; //player to play sound

    private void buttonCheckWord(object sender, EventArgs e) {
		string typedWord = entryTypedWord.Text;
		string wordToGuess = labelSessionWordToGuess.Text;

        string correctWordInEnglish = "";

        foreach (var word in currentWordList) {
            if (wordToGuess == word.inKanjiHiraganaKatakana) {
                correctWordInEnglish = word.inEnglish;
            }
        }

		if(typedWord == correctWordInEnglish) {
            //guessed correctly, maybe add points
            labelHasWordBeenGuessedRight.Text = "You guessed right!";
            labelHasWordBeenGuessedRight.TextColor = Color.FromArgb("#42f545");

            //remove the word from list if guessed correctly
            currentWordList.RemoveAt(idWordToGuess);

            if (currentWordList.Count == 0) {
                buttonNameCheck.IsVisible = false;
                buttonNameNext.IsVisible = false;
                buttonNameLeave.IsVisible = false;
                buttonNameEnd.IsVisible = true;

                entryTypedWord.Text = "";
                entryTypedWord.IsEnabled = false;

                return;
            }
        } else {
            labelHasWordBeenGuessedRight.Text = "Sorry, that's wrong";
            labelHasWordBeenGuessedRight.TextColor = Color.FromArgb("#ff0d2d");

            labelCorrectWordDisplayedWhenWrong.Text = $"The correct word is \"{correctWordInEnglish}\"";
        }

        buttonNameCheck.IsVisible = false;
		buttonNameNext.IsVisible = true;

		entryTypedWord.Text = "";

		entryTypedWord.IsEnabled = false;
		entryTypedWord.IsEnabled = true;

        entryTypedWord.IsReadOnly = true;
    }

    //function to draw next word
    private async void goToNextWord() {
        idWordToGuess = random.Next(currentWordList.Count);

        labelSessionWordToGuess.Text = currentWordList[idWordToGuess].inKanjiHiraganaKatakana;
        labelWordInRomaji.Text = currentWordList[idWordToGuess].inRomaji;

        player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(currentWordList[idWordToGuess].soundOfWord));

    }

    private void buttonNextWord(object sender, EventArgs e) {
		goToNextWord();

		labelHasWordBeenGuessedRight.Text = "";
		labelCorrectWordDisplayedWhenWrong.Text = "";

        buttonNameCheck.IsVisible = true;
        buttonNameNext.IsVisible = false;

        entryTypedWord.IsReadOnly = false;
		entryTypedWord.Focus();
    }

    private async void buttonEndSession(object sender, EventArgs e) {
        await Navigation.PopModalAsync();
    }

    private async void buttonLeave(object sender, EventArgs e) {
        entryTypedWord.IsEnabled = false;

        await Navigation.PopModalAsync();
    }

    private void imageButtonWordSound(object sender, EventArgs e) {
        player.Play();
    }
}