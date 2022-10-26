using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{   
    public MoveForward moveForward;
    public PhysicMaterial physicMaterial;

    public bool isFinished = false;
    private void OnTriggerEnter(Collider other)
    {

        moveForward.speed = 0f;

        //physicMaterial.dynamicFriction = 0;
        //physicMaterial.staticFriction = 0;
    }
    private void LateUpdate()
    {
        if (moveForward.speed == 0)
        {
            isFinished = true;
        }
    }
}
