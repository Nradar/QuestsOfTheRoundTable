using UnityEngine;
using UnityEditor;

static class TestCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/TestCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<TestCardAsset>();
	}
}
