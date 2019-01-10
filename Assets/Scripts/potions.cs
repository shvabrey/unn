using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potions : MonoBehaviour {


    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
