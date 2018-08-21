using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpineController))]
[RequireComponent(typeof(MovementController))]

public class PlayerPhysics : MonoBehaviour {








    public void Move(Vector3 direction) {
        direction = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z) * direction;






        transform.position += direction;
    }

	
	
	
}
