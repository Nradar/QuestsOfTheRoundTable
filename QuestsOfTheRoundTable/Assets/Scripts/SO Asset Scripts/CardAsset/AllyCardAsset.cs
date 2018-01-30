using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum CardType
{
    Foe,
	Weapon,
	Ally,
	Amor,
	Test,
	Quests,
	Tournament,
	Event
}

public class AllyCardAsset : ScriptableObject 
{
    // this object will hold the info about the most general card
    [Header("General info")]
	public string CardTitle;
	public string CardType;
    [TextArea(2,3)]
    public string Description1;  // Description for BP
    [TextArea(2, 3)]
	public string Description2;	// Description for XBP
    public Sprite CardImage;

    [Header("Ally Info")]
    public int BattlePoint;
    public int XBattlePoint = -1;	// Extra Battle Point
	public int Bids;
	public int XBids;
	public bool Ability;
	public string ForQuestName;	// if the card has ability then check stagename == questname
	public bool M;	// merlin
}
