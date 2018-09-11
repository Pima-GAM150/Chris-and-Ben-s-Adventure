using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour {

    public Transform Character;
    public Rigidbody PhysicBody;
    public Transform Camera;
    private Vector3 movement;
    public float Thrust;
    public float Hop;

  
    Vector3 JumpSize = new Vector3(0f, 1f, 0f);

    
    void Update()
    {
        movement.z = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");

        if( Input.GetButtonDown("Jump") ) {
            PhysicBody.AddRelativeForce(JumpSize * Hop, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        Vector3 worldMovement = Camera.TransformDirection( movement ) * Thrust;
        worldMovement.y = PhysicBody.velocity.y;

        PhysicBody.velocity = worldMovement;
    }
}
