using UnityEngine;
using UnityEditor;

static class FoeCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/FoeCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<FoeCardAsset>();
	}
}
