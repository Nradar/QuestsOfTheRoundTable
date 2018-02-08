using UnityEngine;
using UnityEditor;

static class TournamentCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/TournamentCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<TournamentCardAsset>();
	}
}
