using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FoeCardAsset : ScriptableObject 
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

    [Header("Foe Info")]
    public int BattlePoint;
    public int XBattlePoint;	// Extra Battle Point
	public bool Ability;
}
