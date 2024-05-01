namespace slowa_japonski_polski;

public partial class PageWordCategoryList : ContentPage
{
    List<WordClass> wordList = new List<WordClass>();
	public PageWordCategoryList()
	{
		InitializeComponent();

    }


    private async void buttonChoosedWordSet(object sender, EventArgs e) {
        wordList.Clear();

        Button choosedSetButton = (Button)sender;
        string setName = choosedSetButton.Text;

        switch (setName) {
            //A set means easier words, B set - a little harder
            case "Animals A":
                //every set should have about 20 words, A - 20, B - 15
                wordList.Add(new WordClass("neko", "ねこ", "cat", "Animals A"));
                wordList.Add(new WordClass("inu", "いぬ", "dog", "Animals A"));
                wordList.Add(new WordClass("nezumi", "ネズミ", "mouse", "Animals A"));
                wordList.Add(new WordClass("uma", "ウマ", "horse", "Animals A"));
                wordList.Add(new WordClass("hato", "ハト", "pigeon", "Animals A"));
                wordList.Add(new WordClass("buta", "ブタ", "pig", "Animals A"));
                wordList.Add(new WordClass("panda", "パンダ", "panda", "Animals A"));
                wordList.Add(new WordClass("usagi", "ウサギ", "rabbit", "Animals A"));
                wordList.Add(new WordClass("saru", "サル", "monkey", "Animals A"));
                wordList.Add(new WordClass("kirin", "キリン", "giraffe", "Animals A"));
                wordList.Add(new WordClass("kitsune", "キツネ", "fox", "Animals A"));
                wordList.Add(new WordClass("tora", "トラ", "tiger", "Animals A"));
                wordList.Add(new WordClass("raion", "ライオン", "lion", "Animals A"));
                wordList.Add(new WordClass("kuma", "クマ", "bear", "Animals A"));
                wordList.Add(new WordClass("zou", "ゾウ", "elephant", "Animals A"));
                wordList.Add(new WordClass("kaeru", "カエル", "frog", "Animals A"));
                wordList.Add(new WordClass("sakana", "さかな", "fish", "Animals A"));
                wordList.Add(new WordClass("kani", "カニ", "crab", "Animals A"));
                wordList.Add(new WordClass("hebi", "ヘビ", "snake", "Animals A"));
                wordList.Add(new WordClass("kame", "カメ", "turtle", "Animals A"));

                break;
            case "Animals B":
                wordList.Add(new WordClass("niwatori", "ニワトリ", "chicken", "Animals B"));
                wordList.Add(new WordClass("tori", "とり", "bird", "Animals B"));
                wordList.Add(new WordClass("koumori", "コウモリ", "bat", "Animals B"));
                wordList.Add(new WordClass("risu", "リス", "squirrel", "Animals B"));
                wordList.Add(new WordClass("ushi", "ウシ", "cow", "Animals B"));
                wordList.Add(new WordClass("kangaru-", "カンガルー", "kangaroo", "Animals B"));
                wordList.Add(new WordClass("wani", "ワニ", "crocodile", "Animals B"));
                wordList.Add(new WordClass("ika", "イカ", "squid", "Animals B"));
                wordList.Add(new WordClass("ebi", "エビ", "shrimp", "Animals B"));
                wordList.Add(new WordClass("tako", "タコ", "octopus", "Animals B"));
                wordList.Add(new WordClass("same", "サメ", "shark", "Animals B"));
                wordList.Add(new WordClass("ari", "アリ", "ant", "Animals B"));
                wordList.Add(new WordClass("ka", "カ", "mosquito", "Animals B"));
                wordList.Add(new WordClass("hae", "ハエ", "fly", "Animals B"));
                wordList.Add(new WordClass("shichimenchou", "しちめんちょう", "turkey", "Animals B"));

                break;
            default:
                break;
        }

        await Navigation.PushModalAsync(new PageStartedSession(wordList));

    }
}