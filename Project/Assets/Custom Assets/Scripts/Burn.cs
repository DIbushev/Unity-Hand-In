using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;

public class Burn : MonoBehaviour {


    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
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
        anim.SetBool("IsClicked", true);
    }
}
