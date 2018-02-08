using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card
public class AllyCardManager : MonoBehaviour {

	public AllyCardAsset allyCardAsset;
    public AllyCardManager PreviewManager;
    [Header("Text Component References")]
    public Text CardTitleText;
	public Text CardTypeText;
    public Text DescriptionText1;
    public Text DescriptionText2;   //special case in quests
    public int BattlePoint;
    public int XBattlePoint;
	public int Bids;
	public int XBids;
	public bool BidsAbility;
	public bool BattlePointAbility;
	public bool InPlayAbility;
	public string InPlayName;
	public string ForQuestName;	// if the card has ability then check stagename == questname
	public bool M;	// merlin
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
        if (allyCardAsset != null)
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
		CardTitleText.text = allyCardAsset.CardTitle;
        // 3) add card type
		CardTypeText.text = allyCardAsset.CardType;
        // 4) add description
        DescriptionText1.text = allyCardAsset.Description1;
        DescriptionText2.text = allyCardAsset.Description2;
        // 5) Change the card graphic sprite
        CardGraphicImage.sprite = allyCardAsset.CardImage;
		// 6) add card battle point
		BattlePoint = allyCardAsset.BattlePoint;
		// 7) add card extra battle point
		XBattlePoint = allyCardAsset.XBattlePoint;
		// 8) add card bids point
		Bids = allyCardAsset.Bids;
		// 9) add card extra bids point
		XBids = allyCardAsset.XBids;
		// 10) add card battle point condition
		BattlePointAbility = allyCardAsset.BattlePointAbility;
		// 11) add card bids ability
		BidsAbility = allyCardAsset.BidsAbility;
		// 12) add card Inplay Ability
		InPlayAbility = allyCardAsset.InPlayAbility;
		// 13) add card Inplay Name
		InPlayName = allyCardAsset.InPlayName;
		// 13) add card for quest name
		ForQuestName = allyCardAsset.ForQuestName;
		// 14) add card if it is merlin
		M = allyCardAsset.M;

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
            PreviewManager.allyCardAsset = allyCardAsset;
            PreviewManager.ReadCardFromAsset();
        }
    }
}
