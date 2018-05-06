using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using UnityEngine;

public class GetInThere : MonoBehaviour {

    public delegate void ClickedOn();
    public static event ClickedOn Click;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnEnable()
    {
        GetComponent<TapGesture>().Tapped += TapHandler;
    }

    private void OnDisable()
    {
        GetComponent<TapGesture>().Tapped -= TapHandler;
    }

    private void TapHandler(object sender, System.EventArgs e)
    {
        anim.SetBool("IsClicked", true);
        Click();
    }
}

