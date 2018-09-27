using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour {


	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision Death)
   {
     if (Death.gameObject.tag == "Death")
        { 
           GameObject.Find("FPCamera").GetComponent<Mousefollow>().enabled = false;
		   GameObject.Find("Character").GetComponent<NewMovement>().enabled = false;
		   GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;

        }
    }
}
