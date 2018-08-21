using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineController : MonoBehaviour {


    
    GameObject leftWheel;
    GameObject rightWheel;


	void Start () {
        try {
            leftWheel = GameObject.FindGameObjectWithTag("Player1LeftWheel");
            rightWheel = GameObject.FindGameObjectWithTag("Player1RightWheel");
        }
        catch {
            Debug.Log("Error getting gameObject");
        }
        AdjustWheels();
	}
	











    void AdjustLeftWheel() {
        leftWheel.transform.rotation = transform.rotation;
        leftWheel.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z) + transform.forward;
    }

    void AdjustRightWheel() {
        rightWheel.transform.rotation = transform.rotation;
        rightWheel.transform.position = new Vector3(transform.position.x , transform.position.y ,transform.position.z) - transform.forward;

    }

    void AdjustWheels() {
        AdjustLeftWheel();
        AdjustRightWheel();
    }
    
}
