using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAni : MonoBehaviour
{
    public Animator anim;
    public Animation animation;
    void Start()
    {
        anim = GetComponent<Animator>();
        animation["monsteranimation"].speed = 0;
    }
    void onTriggerEnter()
    {
        Debug.Log("yo");
        if(null != anim)
        {
            anim.Play("monsteranimation");
            animation["monsteranimation"].speed = 1;
        }
    }
}
