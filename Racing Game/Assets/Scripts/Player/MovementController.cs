using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {


    public bool controlsEnabled = true;

    float jumpVelocity;
    float gravity;
    Vector3 velocity;
    Vector3 rotation;
    bool gravityEnabled = false;
    PlayerPhysics physics;

    float jumpHeight = 5;
    float timeToJumpApex = 0.3f;



	void Start () {
        physics = this.gameObject.GetComponent<PlayerPhysics>();
        CalculatePhysics(jumpHeight, timeToJumpApex);
    }

    void CalculatePhysics(float jumpHeight, float timeToJumpApex) {
        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        Debug.Log("JumpVelocity =  " + jumpVelocity + "    gravity =  " + gravity);
    }

    private void Update() {




        //gravity
        if (gravityEnabled) {
            velocity.y -= gravity * Time.deltaTime;
        }


        Finish();
    }

    void Finish() {
        physics.Move(velocity * Time.deltaTime, rotation);
    }

    

}
