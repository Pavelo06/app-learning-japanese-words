using Plugin.Maui.Audio;

namespace slowa_japonski_polski;

public partial class PageWordCategoryList : ContentPage
{
    private readonly IAudioManager audioManager;

    List<WordClass> wordList = new List<WordClass>();
	public PageWordCategoryList(IAudioManager audioManager)
	{
		InitializeComponent();
        this.audioManager = audioManager;

    }


    private async void buttonChoosedWordSet(object sender, EventArgs e) {
        wordList.Clear();

        Button choosedSetButton = (Button)sender;
        string setName = choosedSetButton.Text;

        switch (setName) {
            //A set means easier words, B set - a little harder
            case "Animals A":
                wordList.Add(new WordClass("neko", "ねこ", "cat", "Animals A sounds/neko.wav", "Animals A"));
                wordList.Add(new WordClass("inu", "いぬ", "dog", "Animals A sounds/inu.wav", "Animals A"));
                wordList.Add(new WordClass("nezumi", "ネズミ", "mouse", "Animals A sounds/nezumi.wav", "Animals A"));
                wordList.Add(new WordClass("uma", "ウマ", "horse", "Animals A sounds/uma.wav", "Animals A"));
                wordList.Add(new WordClass("hato", "ハト", "pigeon", "Animals A sounds/hato.wav", "Animals A"));
                wordList.Add(new WordClass("buta", "ブタ", "pig", "Animals A sounds/buta.wav", "Animals A"));
                wordList.Add(new WordClass("panda", "パンダ", "panda", "Animals A sounds/panda.wav", "Animals A"));
                wordList.Add(new WordClass("usagi", "ウサギ", "rabbit", "Animals A sounds/usagi.wav", "Animals A"));
                wordList.Add(new WordClass("saru", "サル", "monkey", "Animals A sounds/saru.wav", "Animals A"));
                wordList.Add(new WordClass("kirin", "キリン", "giraffe", "Animals A sounds/kirin.wav", "Animals A"));
                wordList.Add(new WordClass("kitsune", "キツネ", "fox", "Animals A sounds/kitsune.wav", "Animals A"));
                wordList.Add(new WordClass("tora", "トラ", "tiger", "Animals A sounds/tora.wav", "Animals A"));
                wordList.Add(new WordClass("raion", "ライオン", "lion", "Animals A sounds/raion.wav", "Animals A"));
                wordList.Add(new WordClass("kuma", "クマ", "bear", "Animals A sounds/kuma.wav", "Animals A"));
                wordList.Add(new WordClass("zou", "ゾウ", "elephant", "Animals A sounds/zou.wav", "Animals A"));
                wordList.Add(new WordClass("kaeru", "カエル", "frog", "Animals A sounds/kaeru.wav", "Animals A"));
                wordList.Add(new WordClass("sakana", "さかな", "fish", "Animals A sounds/sakana.wav", "Animals A"));
                wordList.Add(new WordClass("kani", "カニ", "crab", "Animals A sounds/kani.wav", "Animals A"));
                wordList.Add(new WordClass("hebi", "ヘビ", "snake", "Animals A sounds/hebi.wav", "Animals A"));
                wordList.Add(new WordClass("kame", "カメ", "turtle", "Animals A sounds/kame.wav", "Animals A"));

                break;

            case "Animals B":
                wordList.Add(new WordClass("niwatori", "ニワトリ", "chicken", "Animals B sounds/niwatori.wav", "Animals B"));
                wordList.Add(new WordClass("tori", "とり", "bird", "Animals B sounds/tori.wav", "Animals B"));
                wordList.Add(new WordClass("koumori", "コウモリ", "Animals B sounds/koumori.wav", "bat", "Animals B"));
                wordList.Add(new WordClass("risu", "リス", "squirrel", "Animals B sounds/risu.wav", "Animals B"));
                wordList.Add(new WordClass("ushi", "ウシ", "cow", "Animals B sounds/ushi.wav", "Animals B"));
                wordList.Add(new WordClass("kangaru-", "カンガルー", "kangaroo", "Animals B sounds/kangaru.wav", "Animals B"));
                wordList.Add(new WordClass("wani", "ワニ", "crocodile", "Animals B sounds/wani.wav", "Animals B"));
                wordList.Add(new WordClass("ika", "イカ", "squid", "Animals B sounds/ika.wav", "Animals B"));
                wordList.Add(new WordClass("ebi", "エビ", "shrimp", "Animals B sounds/ebi.wav", "Animals B"));
                wordList.Add(new WordClass("tako", "タコ", "octopus", "Animals B sounds/tako.wav", "Animals B"));
                wordList.Add(new WordClass("same", "サメ", "shark", "Animals B sounds/same.wav", "Animals B"));
                wordList.Add(new WordClass("ari", "アリ", "ant", "Animals B sounds/ari.wav", "Animals B"));
                wordList.Add(new WordClass("ka", "カ", "mosquito", "Animals B sounds/ka.wav", "Animals B"));
                wordList.Add(new WordClass("hae", "ハエ", "fly", "Animals B sounds/hae.wav", "Animals B"));
                wordList.Add(new WordClass("shichimenchou", "しちめんちょう", "turkey", "Animals B sounds/shichimenchou.wav", "Animals B"));

                break;

            case "Human Face Parts":
               /* wordList.Add(new WordClass("kaminoke", "髪の毛", "hair", "Human Face Parts"));
                wordList.Add(new WordClass("hitai", "ひたい", "forehead", "Human Face Parts"));
                wordList.Add(new WordClass("me", "目", "eyes", "Human Face Parts"));
                wordList.Add(new WordClass("mimi", "耳", "ear", "Human Face Parts"));
                wordList.Add(new WordClass("hana", "鼻", "nose", "Human Face Parts"));
                wordList.Add(new WordClass("hoho", "ほほ", "cheek", "Human Face Parts"));
                wordList.Add(new WordClass("kuchi", "口", "mouth", "Human Face Parts"));
                wordList.Add(new WordClass("teeth", "歯 ", "ha", "Human Face Parts"));
                wordList.Add(new WordClass("shita", "舌", "tounge", "Human Face Parts"));*/

                break;

            case "Human Body Parts":
                //wordList.Add(new WordClass("atama", "頭", "head", "Human Body Parts"));
                //wordList.Add(new WordClass("ude", "腕", "arm", "Human Body Parts"));
                //wordList.Add(new WordClass("yubi", "指", "finger", "Human Body Parts"));
                //wordList.Add(new WordClass("mune", "胸", "chest", "Human Body Parts"));
                //wordList.Add(new WordClass("hara", "腹", "stomach", "Human Body Parts"));
                //wordList.Add(new WordClass("ashi", "脚", "leg", "Human Body Parts"));
                //wordList.Add(new WordClass("ashi", "足", "foot", "Human Body Parts"));
                //wordList.Add(new WordClass("hiza", "ひざ", "knee", "Human Body Parts"));
                //wordList.Add(new WordClass("kubi", "首", "neck", "Human Body Parts"));
                //wordList.Add(new WordClass("nodo", "のど", "throat", "Human Body Parts"));
                //wordList.Add(new WordClass("hiji", "ひじ", "elbow", "Human Body Parts"));
                //wordList.Add(new WordClass("shiri", "尻", "hip", "Human Body Parts"));

                break;

            case "Fruits":
                //wordList.Add(new WordClass("ichigo", "イチゴ", "strawberry", "Fruits"));
                //wordList.Add(new WordClass("orenji", "オレンジ", "orange", "Fruits"));
                //wordList.Add(new WordClass("ringo", "りんご", "apple", "Fruits"));
                //wordList.Add(new WordClass("remon", "レモン", "lemon", "Fruits"));
                //wordList.Add(new WordClass("budō", "ぶどう", "grape", "Fruits"));
                //wordList.Add(new WordClass("banana", "バナナ", "banana", "Fruits"));
                //wordList.Add(new WordClass("momo", "もも", "peach", "Fruits"));
                //wordList.Add(new WordClass("suika", "スイカ", "watermelon", "Fruits"));
                //wordList.Add(new WordClass("kiui", "キウイ", "kiwi", "Fruits"));
                //wordList.Add(new WordClass("mangō", "マンゴー", "mango", "Fruits"));
                //wordList.Add(new WordClass("sakuranbo", "さくらんぼ", "cherry", "Fruits"));
                //wordList.Add(new WordClass("kudamono", "くだもの", "fruit", "Fruits"));
                //wordList.Add(new WordClass("painappuru", "パイナップル", "pineapple", "Fruits"));

                break;

            case "Vegetables":
                //wordList.Add(new WordClass("yasai", "やさい", "vegetable", "Vegetables"));
                //wordList.Add(new WordClass("ninjin", "にんじん", "carrot", "Vegetables"));
                //wordList.Add(new WordClass("daikon", "だいこん", "white raddish", "Vegetables"));
                //wordList.Add(new WordClass("jagaimo", "ジャガイモ", "potato", "Vegetables"));
                //wordList.Add(new WordClass("nasu", "なす", "eggplant", "Vegetables"));
                //wordList.Add(new WordClass("tomato", "トマト", "tomato", "Vegetables"));
                //wordList.Add(new WordClass("tamanegi", "たまねぎ", "onion", "Vegetables"));
                //wordList.Add(new WordClass("kyūri", "きゅうり", "cucumber", "Vegetables"));
                //wordList.Add(new WordClass("tōmorokoshi", "トウモロコシ", "corn", "Vegetables"));
                //wordList.Add(new WordClass("kabocha", "かぼちゃ", "pumpkin", "Vegetables"));
                //wordList.Add(new WordClass("retasu", "レタス", "lettuce", "Vegetables"));
                //wordList.Add(new WordClass("kyabetsu", "キャベツ", "cabbage", "Vegetables"));
                //wordList.Add(new WordClass("ninniku", "ニンニク", "garlic", "Vegetables"));
                //wordList.Add(new WordClass("kinoko", "キノコ", "mushroom", "Vegetables"));
                //wordList.Add(new WordClass("shōga", "しょうが", "ginger", "Vegetables"));
                //wordList.Add(new WordClass("hōrensō", "ほうれんそう", "spinach", "Vegetables"));

                break;
            default:
                break;
        }

        await Navigation.PushModalAsync(new PageStartedSession(wordList, audioManager));

    }
}