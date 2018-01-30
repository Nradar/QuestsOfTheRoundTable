using UnityEngine;
using UnityEditor;

static class FoeCardUnityIntegration 
{

	[MenuItem("Assets/Create/FoeCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<FoeCardAsset>();
	}
}
