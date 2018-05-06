using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeReturn : MonoBehaviour {

    private void OnEnable()
    {
        GetComponent<PressGesture>().Pressed += PressHandler;
    }

    private void OnDisable()
    {
        GetComponent<PressGesture>().Pressed -= PressHandler;
    }

    private void PressHandler(object sender, System.EventArgs e)
    {
        SceneManager.LoadScene("Proj", LoadSceneMode.Single);
    }
}
