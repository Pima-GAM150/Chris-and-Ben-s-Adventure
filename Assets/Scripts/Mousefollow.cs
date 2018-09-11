using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousefollow : MonoBehaviour {
    public float speedH = 2f;
    public float speedV = 2f;

    private float Dis = 0f;
    private float Dat = 0f;
 
	// Update is called once per frame
	void Update () {
        //the mouse inputs are used in the EulerAngles of the transform.
        //i used clamp to stop it from looking up to much or down to much.
        Dis -= speedH * Input.GetAxis("Mouse Y");
        Dat += speedV * Input.GetAxis("Mouse X");
        print(Dis);
       
        
            transform.eulerAngles = new Vector3(Mathf.Clamp(Dis, -89, 89), Dat, 0f);
        
       
    }
}
