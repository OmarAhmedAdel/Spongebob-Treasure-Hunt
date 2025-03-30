using UnityEngine;
using UnityEngine.UIElements;

public class ScrollViewTextAdder : MonoBehaviour
{
    public UIDocument uiDocument;
    private string largeText;

    private ScrollView scrollView;

    private void OnEnable()
    {
        scrollView = uiDocument.rootVisualElement.Q<ScrollView>();

    largeText = @"Developers:
Omar Tamer 52-11870
Mohamed Ayman 52-20136
Omar Adel 52-9190
Ahmed Monsef 52-15723
Abdelrahman Saleh 52-11256

Models:
Treasure chest: https://sketchfab.com/3d-models/sandy-treasure-chest-1cf15b0f7a2e414091c7cf0464071140#download
Pirate Ship: https://sketchfab.com/3d-models/pirate-ship-367a426b3f814bd2abbf68532f0d6078#download
Clarinet: https://sketchfab.com/3d-models/squidwards-clarinet-spongebob-f4d181dd05a24c259ba612cf68961445
Jellyfish: https://sketchfab.com/3d-models/jelly-fish-spongebob-4227c0c46a1640ef9c61c455f7bc10f7#download
Mr Krabs: https://sketchfab.com/3d-models/mr-krabs-b5c000294b084ad5b3439c9e0738bcb4
Treasure Map: https://sketchfab.com/3d-models/adventure-map-553b41ef1c0e489a999844139b78f6d9#download
Krusty Krabs interior: https://sketchfab.com/3d-models/sbfbb-the-krusty-krab-c0dfeb224acc469694ce5f9a602b0aa7
Chairs: https://sketchfab.com/3d-models/sbfbb-the-krusty-krab-c0dfeb224acc469694ce5f9a602b0aa7
Barrel: https://sketchfab.com/3d-models/barrel-624a5490b41e4e36b86bba2313cd16b5
Crate: https://sketchfab.com/3d-models/wooden-crate-5f7ee0b43aaa4e36bfaa7e25f5609f96#download
Squidward: https://sketchfab.com/3d-models/squidward-spongebob-7b493d23a7d941639b92cb162c175611
Patrick: https://sketchfab.com/3d-models/patrick-rigged-19939d59bb5a448bb6ea041d8b931f41
SpongeBob: https://sketchfab.com/3d-models/spongebob-squarepants-4dc65614da13403fa45a9710b4b4d655
Exterior Map: https://sketchfab.com/3d-models/jellyfish-fields-spongebob-squarepants-bfbb-aa9014cd583049d2bdd63fa953e9f27e
Sandy: https://sketchfab.com/3d-models/sandy-spongebob-square-pants-16dcf4dc041a42589da92eabba610e1b


Sounds:
Mr krabs laugh : https://www.myinstants.com/en/instant/mr-krabs-40355/
Thinking: https://freesound.org/people/kanyonwyvern/sounds/727360/
Mr krabs walk: https://freesound.org/people/kretopi/sounds/406750/
Talking: https://freesound.org/people/se2001/sounds/463820/
SpongeBob walking: https://www.myinstants.com/en/instant/spongebob-walk-63063/
Surprised: https://freesound.org/people/simon.rue/sounds/49953/
spongebob talk: https://www.myinstants.com/en/instant/spongebob-im-ready/
water steps:https://pixabay.com/sound-effects/deep-water-footsteps-50719/
falling sound:https://pixabay.com/sound-effects/falling-bomb-41038/
Walking Sound Effect: https://www.youtube.com/watch?v=468wUxjLTs0
https://www.myinstants.com/en/instant/dramatic-cue-a-14662/
https://www.myinstants.com/en/instant/squidward-yells-spongebob/
https://youtu.be/dbnAdEpQ6H4
https://www.myinstants.com/en/instant/victory-screech-spongebob/
https://www.myinstants.com/en/instant/squidward-walking-2541/
https://www.myinstants.com/en/instant/spongebob-boat-horn-84013/
https://www.myinstants.com/en/instant/mario-wins/
https://www.myinstants.com/en/instant/spongebob-trap-remix/
https://www.myinstants.com/en/instant/vibe-link-b-54141/
https://www.myinstants.com/en/instant/spongebob-a-few-moments-later-39115/
https://www.myinstants.com/en/instant/spongebob-walk-63063/
https://www.myinstants.com/en/instant/spongebob-one-hour-later-46392/
https://www.myinstants.com/en/instant/spongebob-one-hour-later-46392/
https://www.myinstants.com/en/instant/spongebob-laugh-23766/
https://www.myinstants.com/en/instant/spongebob-im-ready/
choose direction: https://www.myinstants.com/en/instant/dramatic-impact/
https://www.myinstants.com/en/instant/vibe-link-b-54141/


background: https://www.zedge.net/ringtones/cbdce66c-6bed-3849-9137-f6b21b559619

background 2: https://www.myinstants.com/en/instant/spongebob-trap-remix/

Main Menu: https://www.myinstants.com/en/instant/spongebob-theme-76331/


background Image (main menu): https://spongebob.fandom.com/wiki/The_Flying_Dutchman%27s_Treasure_Hunt

Font: https://assetstore.unity.com/packages/2d/fonts/fatality-fps-gaming-font-216954

Buttons: https://assetstore.unity.com/packages/2d/gui/buttons-set-211824


Main Menu Textures: https://assetstore.unity.com/packages/2d/gui/fantasy-wooden-gui-free-103811
";
        if (scrollView == null)
        {
            Debug.LogError("No ScrollView found in the UI Document!");
            return;
        }

        AddTextToScrollView(largeText);
    }

    private void AddTextToScrollView(string text)
    {
        Label textLabel = new Label
        {
            text = text,
            style =
            {
                unityTextAlign = TextAnchor.UpperLeft, 
                whiteSpace = WhiteSpace.Normal,
                fontSize = 46
            }
        };

        scrollView.Add(textLabel);
    }
}
