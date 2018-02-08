using UnityEngine;
using UnityEditor;

static class EventCardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset/EventCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<EventCardAsset>();
	}
}
