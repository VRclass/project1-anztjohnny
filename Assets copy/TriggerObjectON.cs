using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObjectON : MonoBehaviour
{
    public Light ligthToSwitch = null;
    public GameObject myObj = null;
    
    // When the trigger is entered 
    public void OnTriggerEnter(Collider other)
    {
        myObj.SetActive(true);
        //myObj.enabled = true;
        ligthToSwitch.enabled = true; // turn the light off
        print("entered the ON trigger");  // print the message
    }

}