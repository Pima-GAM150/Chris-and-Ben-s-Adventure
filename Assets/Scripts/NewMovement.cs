using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMovement : MonoBehaviour {

    public Transform Character;
    public Rigidbody PhysicBody;
    public Transform Camera;
    private Vector3 movement;
    public float Thrust;
    public float Hop;
    int contacts = 1;

  
    Vector3 JumpSize = new Vector3(0f, 1f, 0f);

    void Start(){
         PlayerPrefs.SetInt("lastLevel", SceneManager.GetActiveScene().buildIndex);
    }
    void Update()
    {
        
        movement.z = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");

        if( Input.GetButtonDown("Jump") ) {
            
            if (contacts > 0) {

                PhysicBody.AddRelativeForce(JumpSize * Hop, ForceMode.Impulse);
                contacts = 0;
            }
           
        }
    }

    private void FixedUpdate()
    {
        Vector3 worldMovement = Camera.TransformDirection( movement ) * Thrust;
        worldMovement.y = PhysicBody.velocity.y;

        PhysicBody.velocity = worldMovement;
    }

    void OnCollisionEnter(Collision col)
   {
     if (col.gameObject.tag == "Floor")
        {
            print(contacts);
            contacts = 1;
        }
        
   }
   
}
