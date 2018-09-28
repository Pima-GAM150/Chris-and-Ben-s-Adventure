using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeWallRight : MonoBehaviour {

	public float offset;
	public float Secondoffset;
	public float reset;
	public float amountdirection = -.05f;
	public float pause;
	private float timer;
    private float seconds = 1f;


	void Start () {
		timer = seconds += Time.deltaTime;
	 
	}
	
	// Update is called once per frame
	void Update () {
		timer = seconds += Time.deltaTime;
		if (timer <= offset)
        {
            transform.position = new Vector3(transform.position.x + amountdirection, transform.position.y, transform.position.z);
        }
        if (timer >= Secondoffset)
        {
          transform.position = new Vector3(transform.position.x - amountdirection, transform.position.y, transform.position.z);
            
        }
        
        if (timer >= reset)
        {
            seconds = 0;
        }
		
	}
}
