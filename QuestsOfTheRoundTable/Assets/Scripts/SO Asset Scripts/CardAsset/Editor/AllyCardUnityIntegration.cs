using UnityEngine;
using UnityEditor;

static class AllyCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/AllyCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<AllyCardAsset>();
	}
}
