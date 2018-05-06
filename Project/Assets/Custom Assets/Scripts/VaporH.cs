using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaporH : MonoBehaviour {

    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        GetInThere.Click += Animate;
    }

    private void OnDisable()
    {
        GetInThere.Click -= Animate;
    }

    private void Animate()
    {
        anim.SetBool("IsPlayed", true);
    }
}

