using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public MoveForward moveForward;
    public PhysicMaterial physicMaterial;
    
    private void OnTriggerEnter(Collider other)
    {
        moveForward.rb.drag = 4;                
    }
    
}
