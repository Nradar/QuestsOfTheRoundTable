using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ShieldPoolVisual : MonoBehaviour {

    public int TestFullShields;    //TestFullCrystals
    public int TestTotalShieldsThisTurn;   //TestTotalCrystalsThisTurn

    private int totalShields;   //totalCrystals
    public int TotalShields    //TotalCrystals
    {
        get{ return totalShields; }

        set
        {
            //Debug.Log("Changed total shields to: " + value);

            if (value > Shields.Length)
                totalShields = Shields.Length;
            else if (value < 0)
                totalShields = 0;
            else
                totalShields = value;

            for (int i = 0; i < Shields.Length; i++)
            {
                if (i < totalShields)
                {
                    if (Shields[i].color == Color.clear)
                        Shields[i].color = Color.gray;
                }
                else
                    Shields[i].color = Color.clear;
            }

            // update the text
            ProgressText.text = string.Format("{0}/{1}", availableShields.ToString(), totalShields.ToString());
        }
    }

    private int availableShields;  //availableCrystals
    public int AvailableShields    //AvailableCrystals
    {
        get{ return availableShields; }

        set
        {
            //Debug.Log("Changed mana this turn to: " + value);

            if (value > totalShields)
                availableShields = totalShields;
            else if (value < 0)
                availableShields = 0;
            else
                availableShields = value;

            for (int i = 0; i < totalShields; i++)
            {
                if (i < availableShields)
                    Shields[i].color = Color.white;
                else
                    Shields[i].color = Color.gray;
            }

            // update the text
            ProgressText.text = string.Format("{0}/{1}", availableShields.ToString(), totalShields.ToString());

        }
    }
    public Image[] Shields;
    public Text ProgressText;

    
    void Update()
    {
        if (Application.isEditor && !Application.isPlaying)
        {
            TotalShields = TestTotalShieldsThisTurn;
            AvailableShields = TestFullShields;
        }
    }
	
}
