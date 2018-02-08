﻿using UnityEngine;
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

public enum Events
{
	ChivalrousDeed,
	Pox,
	Plague,
	KingsRecognition,
	QueensFavor,
	CourtCalledtoCamelot,
	KingsCalltoArms,
	ProsperityThroughouttheRealm
}

public class EventCardAsset : ScriptableObject 
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

    [Header("Event Info")]
	//public string EventName;
	public Events EventName;
}
