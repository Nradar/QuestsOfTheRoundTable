<<<<<<< HEAD
﻿using UnityEngine;
using UnityEditor;

static class CardUnityIntegration 
{

	[MenuItem("Assets/Create/AllyCardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<AllyCardAsset>();
	}
}
=======
﻿using UnityEngine;
using UnityEditor;

static class CardUnityIntegration 
{

	[MenuItem("Assets/Create/CardAsset")]
	public static void CreateYourScriptableObject() {
		ScriptableObjectUtility2.CreateAsset<CardAsset>();
	}

}
>>>>>>> 5193afe3418ee407bc93b7dde5998b7b1f45993c
