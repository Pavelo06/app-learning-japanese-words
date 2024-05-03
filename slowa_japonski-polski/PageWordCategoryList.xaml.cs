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
                wordList.Add(new WordClass("koumori", "コウモリ", "bat", "Animals B sounds/koumori.wav", "Animals B"));
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
                wordList.Add(new WordClass("kaminoke", "髪の毛", "hair", "Human Face Parts sounds/kaminoke.wav", "Human Face Parts"));
                wordList.Add(new WordClass("hitai", "ひたい", "forehead", "Human Face Parts sounds/hitai.wav", "Human Face Parts"));
                wordList.Add(new WordClass("me", "目", "eyes", "Human Face Parts sounds/me.wav", "Human Face Parts"));
                wordList.Add(new WordClass("mimi", "耳", "ear", "Human Face Parts sounds/mimi.wav", "Human Face Parts"));
                wordList.Add(new WordClass("hana", "鼻", "nose", "Human Face Parts sounds/hana.wav", "Human Face Parts"));
                wordList.Add(new WordClass("hoho", "ほほ", "cheek", "Human Face Parts sounds/hoho.wav", "Human Face Parts"));
                wordList.Add(new WordClass("kuchi", "口", "mouth", "Human Face Parts sounds/kuchi.wav", "Human Face Parts"));
                wordList.Add(new WordClass("ha", "歯 ", "teeth", "Human Face Parts sounds/ha.wav", "Human Face Parts"));
                wordList.Add(new WordClass("shita", "舌", "tounge", "Human Face Parts sounds/shita.wav", "Human Face Parts"));

                break;

            case "Human Body Parts":
                wordList.Add(new WordClass("atama", "頭", "head", "Human Body Parts sounds/atama.wav", "Human Body Parts"));
                wordList.Add(new WordClass("ude", "腕", "arm", "Human Body Parts sounds/ude.wav", "Human Body Parts"));
                wordList.Add(new WordClass("yubi", "指", "finger", "Human Body Parts sounds/yubi.wav", "Human Body Parts"));
                wordList.Add(new WordClass("mune", "胸", "chest", "Human Body Parts sounds/mune.wav", "Human Body Parts"));
                wordList.Add(new WordClass("hara", "腹", "stomach", "Human Body Parts sounds/hara.wav", "Human Body Parts"));
                wordList.Add(new WordClass("ashi", "脚", "leg", "Human Body Parts sounds/ashi.wav", "Human Body Parts"));
                wordList.Add(new WordClass("ashi", "足", "foot", "Human Body Parts sounds/ashi.wav", "Human Body Parts"));
                wordList.Add(new WordClass("hiza", "ひざ", "knee", "Human Body Parts sounds/hiza.wav", "Human Body Parts"));
                wordList.Add(new WordClass("kubi", "首", "neck", "Human Body Parts sounds/kubi.wav", "Human Body Parts"));
                wordList.Add(new WordClass("nodo", "のど", "throat", "Human Body Parts sounds/nodo.wav", "Human Body Parts"));
                wordList.Add(new WordClass("hiji", "ひじ", "elbow", "Human Body Parts sounds/hiji.wav", "Human Body Parts"));
                wordList.Add(new WordClass("shiri", "尻", "hip", "Human Body Parts sounds/shiri.wav", "Human Body Parts"));

                break;

            case "Fruits":
                wordList.Add(new WordClass("ichigo", "イチゴ", "strawberry", "Fruits sounds/ichigo.wav", "Fruits"));
                wordList.Add(new WordClass("orenji", "オレンジ", "orange", "Fruits sounds/orenji.wav", "Fruits"));
                wordList.Add(new WordClass("ringo", "りんご", "apple", "Fruits sounds/ringo.wav", "Fruits"));
                wordList.Add(new WordClass("remon", "レモン", "lemon", "Fruits sounds/remon.wav", "Fruits"));
                wordList.Add(new WordClass("budou", "ぶどう", "grape", "Fruits sounds/budou.wav", "Fruits"));
                wordList.Add(new WordClass("banana", "バナナ", "banana", "Fruits sounds/banana.wav", "Fruits"));
                wordList.Add(new WordClass("momo", "もも", "peach", "Fruits sounds/momo.wav", "Fruits"));
                wordList.Add(new WordClass("suika", "スイカ", "watermelon", "Fruits sounds/suika.wav", "Fruits"));
                wordList.Add(new WordClass("kiui", "キウイ", "kiwi", "Fruits sounds/kiui.wav", "Fruits"));
                wordList.Add(new WordClass("mangoo", "マンゴー", "mango", "Fruits sounds/mangoo.wav", "Fruits"));
                wordList.Add(new WordClass("sakuranbo", "さくらんぼ", "cherry", "Fruits sounds/sakuranbo.wav", "Fruits"));
                wordList.Add(new WordClass("kudamono", "くだもの", "fruit", "Fruits sounds/kudamono.wav", "Fruits"));
                wordList.Add(new WordClass("painappuru", "パイナップル", "pineapple", "Fruits sounds/painappuru.wav", "Fruits"));

                break;

            case "Vegetables":
                wordList.Add(new WordClass("yasai", "やさい", "vegetable", "Vegetables sounds/yasai.wav", "Vegetables"));
                wordList.Add(new WordClass("ninjin", "にんじん", "carrot", "Vegetables sounds/ninjin.wav", "Vegetables"));
                wordList.Add(new WordClass("daikon", "だいこん", "white raddish", "Vegetables sounds/daikon.wav", "Vegetables"));
                wordList.Add(new WordClass("jagaimo", "ジャガイモ", "potato", "Vegetables sounds/jagaimo.wav", "Vegetables"));
                wordList.Add(new WordClass("nasu", "なす", "eggplant", "Vegetables sounds/nasu.wav", "Vegetables"));
                wordList.Add(new WordClass("tomato", "トマト", "tomato", "Vegetables sounds/tomato.wav", "Vegetables"));
                wordList.Add(new WordClass("tamanegi", "たまねぎ", "onion", "Vegetables sounds/tamanegi.wav", "Vegetables"));
                wordList.Add(new WordClass("kyuuri", "きゅうり", "cucumber", "Vegetables sounds/kyuuri.wav", "Vegetables"));
                wordList.Add(new WordClass("kabocha", "かぼちゃ", "pumpkin", "Vegetables sounds/kabocha.wav", "Vegetables"));
                wordList.Add(new WordClass("retasu", "レタス", "lettuce", "Vegetables sounds/retasu.wav", "Vegetables"));
                wordList.Add(new WordClass("kyabetsu", "キャベツ", "cabbage", "Vegetables sounds/kyabetsu.wav", "Vegetables"));
                wordList.Add(new WordClass("ninniku", "ニンニク", "garlic", "Vegetables sounds/ninniku.wav", "Vegetables"));
                wordList.Add(new WordClass("kinoko", "キノコ", "mushroom", "Vegetables sounds/kinoko.wav", "Vegetables"));
                wordList.Add(new WordClass("shouga", "しょうが", "ginger", "Vegetables sounds/shouga.wav", "Vegetables"));

                break;

            case "Western Food":
                wordList.Add(new WordClass("suupu", "スープ", "soup", "Western Food sounds/suupu.wav", "Western Food"));
                wordList.Add(new WordClass("sarada", "サラダ", "salad", "Western Food sounds/sarada.wav", "Western Food"));
                wordList.Add(new WordClass("sandoitchi", "サンドイッチ", "sandwich", "Western Food sounds/sandoitchi.wav", "Western Food"));
                wordList.Add(new WordClass("hanbaagaa", "ハンバーガー", "hamburger", "Western Food sounds/hanbaagaa.wav", "Western Food"));
                wordList.Add(new WordClass("hottodoggu", "ホットドッグ", "hotdog", "Western Food sounds/hottodoggu.wav", "Western Food"));
                wordList.Add(new WordClass("poteto", "ポテト", "fries", "Western Food sounds/poteto.wav", "Western Food"));
                wordList.Add(new WordClass("furaidochikin", "フライドチキン", "fried chicken", "Western Food sounds/furaidochikin.wav", "Western Food"));
                wordList.Add(new WordClass("suteeki", "ステーキ", "steak", "Western Food sounds/suteeki.wav", "Western Food"));
                wordList.Add(new WordClass("piza", "ピザ", "pizza", "Western Food sounds/piza.wav", "Western Food"));
                wordList.Add(new WordClass("supagettii", "スパゲッティー", "spaghetti", "Western Food sounds/supagettii.wav", "Western Food"));

                break;
            default:
                break;
        }

        await Navigation.PushModalAsync(new PageStartedSession(wordList, audioManager));

    }
}