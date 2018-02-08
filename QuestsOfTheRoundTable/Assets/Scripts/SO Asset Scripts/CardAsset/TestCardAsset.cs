using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestCardAsset : ScriptableObject 
{
    // this object will hold the info about the most general card
    [Header("General info")]
	public string CardTitle;
	public string CardType;
    [TextArea(2,3)]
    public string Description1;  // Description for BP
    //[TextArea(2, 3)]
	//public string Description2;	// Description for XBP
    public Sprite CardImage;

    [Header("Test Info")]
    public int Bids;
    public int XBids;	// Extra Battle Point
	public bool Ability;
	public string ForQuestName;
}
