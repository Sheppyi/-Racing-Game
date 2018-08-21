using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWheelScript : MonoBehaviour {

    MovementController movementController;
    float maxScale = 1.5f;
    float minScale = 0.5f;
    float size;

    private void Start() {
        movementController = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();
    }

    private void Update() {
        if (movementController.controlsEnabled) {
            var input = GetInput.axis_left_vertical;
            if (Mathf.Abs(input) > GameSettings.axisLeftVerticalDeadzone) {
                if (input > 0) {
                    size = SuperLerp(1, minScale, (float)(GameSettings.axisLeftVerticalDeadzone), 0.9f, input);
                    GetComponent<SphereCollider>().radius = size;
                }
                else {
                    size = SuperLerp(maxScale, 1, -0.9f, (float)(-GameSettings.axisLeftVerticalDeadzone), input);
                    GetComponent<SphereCollider>().radius = 1;
                }
            }
            else {
                size = 1;
                GetComponent<SphereCollider>().radius = size;
            }
            transform.localScale = new Vector3(size, size, 1);
        }
    }


    float SuperLerp(float from, float to, float from2, float to2, float value) {
        if (value <= from2)
            return from;
        else if (value >= to2)
            return to;
        return (to - from) * ((value - from2) / (to2 - from2)) + from;
    }
}
