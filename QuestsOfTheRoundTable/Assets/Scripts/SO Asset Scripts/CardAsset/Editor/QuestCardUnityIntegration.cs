using UnityEngine;
using UnityEditor;

static class QuestCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/QuestCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<QuestCardAsset>();
	}
}
