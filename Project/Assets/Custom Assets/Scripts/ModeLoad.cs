using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;
using UnityEngine.SceneManagement;

public class ModeLoad : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

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
            SceneManager.LoadScene("Proj2", LoadSceneMode.Single);
    }
}
