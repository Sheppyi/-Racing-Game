using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpineController))]
[RequireComponent(typeof(MovementController))]

public class PlayerPhysics : MonoBehaviour {


    GameObject rightWheelObj;
    GameObject leftWheelObj;



    private void Start() {
        rightWheelObj = GameObject.FindGameObjectWithTag("Player1RightWheel");
        leftWheelObj = GameObject.FindGameObjectWithTag("Player1LeftWheel");
    }



    public void Move(Vector3 direction, Vector3 rotation) {
        direction = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z) * direction;
 

        transform.position += direction;
    }

	


	
	
}


