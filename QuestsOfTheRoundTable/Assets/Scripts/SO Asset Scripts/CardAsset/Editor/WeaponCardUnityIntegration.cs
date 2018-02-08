using UnityEngine;
using UnityEditor;

static class WeaponCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/WeaponCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<WeaponCardAsset>();
	}
}
