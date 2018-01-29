using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMainMenu : MonoBehaviour {

    public void backToMM()
    {
        Debug.Log("scene load "+SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("menu", LoadSceneMode.Additive);
        Debug.Log("back button pressed");
    }

}
