using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card
public class TestCardManager : MonoBehaviour {

	public TestCardAsset testCardAsset;
    public TestCardManager PreviewManager;
    [Header("Text Component References")]
    public Text CardTitleText;
	public Text CardTypeText;
    public Text DescriptionText1;     //Description for Bids
    //public Text DescriptionText2;   //special case in quests
    public int Bids;
    public int XBids;
	public bool Ability;
	public string ForQuestName;
    //[Header ("GameObject References")]
    //public GameObject HealthIcon;
    //public GameObject AttackIcon;
    [Header("Image References")]
    public Image CardTopRibbonImage;
    public Image CardLowRibbonImage;
    public Image CardGraphicImage;
    public Image CardBodyImage;
    public Image CardFaceFrameImage;
    public Image CardFaceGlowImage;
    public Image CardBackGlowImage;

    void Awake()
    {
        if (testCardAsset != null)
            ReadCardFromAsset();
    }

    private bool canBePlayedNow = false;
    public bool CanBePlayedNow
    {
        get
        {
            return canBePlayedNow;
        }

        set
        {
            canBePlayedNow = value;

            CardFaceGlowImage.enabled = value;
        }
    }

    public void ReadCardFromAsset()
    {
        // universal actions for any Card
        // 1) apply tint
        /*if (foeCardAsset.characterAsset != null)
        {
            CardBodyImage.color = cardAsset.characterAsset.ClassCardTint;
            CardFaceFrameImage.color = cardAsset.characterAsset.ClassCardTint;
            CardTopRibbonImage.color = cardAsset.characterAsset.ClassRibbonsTint;
            CardLowRibbonImage.color = cardAsset.characterAsset.ClassRibbonsTint;
        }
        else
        {
            //CardBodyImage.color = GlobalSettings.Instance.CardBodyStandardColor;
            CardFaceFrameImage.color = Color.white;
            //CardTopRibbonImage.color = GlobalSettings.Instance.CardRibbonsStandardColor;
            //CardLowRibbonImage.color = GlobalSettings.Instance.CardRibbonsStandardColor;
        }*/
        // 2) add card title
		CardTitleText.text = testCardAsset.CardTitle;
        // 3) add card type
		CardTypeText.text = testCardAsset.CardType;
        // 4) add description
        DescriptionText1.text = testCardAsset.Description1;
        //DescriptionText2.text = testCardAsset.Description2;
        // 5) Change the card graphic sprite
        CardGraphicImage.sprite = testCardAsset.CardImage;
		// 6) add card bids
		Bids = testCardAsset.Bids;
		// 7) add card extra bids
		XBids = testCardAsset.XBids;
		// 8) add card ability condition
		Ability = testCardAsset.Ability;
		// 9) add card forQuestName
		ForQuestName = testCardAsset.ForQuestName;

        /*if (cardAsset.MaxHealth != 0)
        {
            // this is a creature
            AttackText.text = cardAsset.Attack.ToString();
            HealthText.text = cardAsset.MaxHealth.ToString();
        }*/

        if (PreviewManager != null)
        {
            // this is a card and not a preview
            // Preview GameObject will have OneCardManager as well, but PreviewManager should be null there
            PreviewManager.testCardAsset = testCardAsset;
            PreviewManager.ReadCardFromAsset();
        }
    }
}
