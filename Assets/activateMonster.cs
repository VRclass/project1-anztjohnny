using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateMonster : MonoBehaviour
{
    public GameObject monster;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        monster.SetActive(true);
    }
}
