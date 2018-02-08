using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*public enum CardType
{
    Foe,
	Weapon,
	Ally,
	Amor,
	Test,
	Quests,
	Tournament,
	Event
}*/

public class QuestCardAsset : ScriptableObject 
{
    // this object will hold the info about the most general card
    [Header("General info")]
	public string CardTitle;
	public string CardType;
    [TextArea(2,3)]
    public string Description1;  // Description for Ability Foe Name
    [TextArea(2, 3)]
	public string Description2;	// Description for Stage Numbers
    public Sprite CardImage;

    [Header("Quest Info")]
	public int Stages;
	public string FoeName;
	public bool Ability;
}
