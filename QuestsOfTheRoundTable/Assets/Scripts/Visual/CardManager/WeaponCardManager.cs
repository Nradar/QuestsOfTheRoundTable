using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// holds the refs to all the Text, Images on the card
public class WeaponCardManager : MonoBehaviour {

	public WeaponCardAsset weaponCardAsset;
    public WeaponCardManager PreviewManager;
    [Header("Text Component References")]
    public Text CardTitleText;
	public Text CardTypeText;
    public Text DescriptionText1;   //Description for BP
	//public Text DescriptionText2;
    public int BattlePoint;
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
        if (weaponCardAsset != null)
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
		CardTitleText.text = weaponCardAsset.CardTitle;
        // 3) add card type
		CardTypeText.text = weaponCardAsset.CardType;
        // 4) add description
        DescriptionText1.text = weaponCardAsset.Description1;
		//DescriptionText2.text = weaponCardAsset.Description2;
        // 5) Change the card graphic sprite
        CardGraphicImage.sprite = weaponCardAsset.CardImage;
		// 6) add card battle point
		BattlePoint = weaponCardAsset.BattlePoint;

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
            PreviewManager.weaponCardAsset = weaponCardAsset;
            PreviewManager.ReadCardFromAsset();
        }
    }
}
