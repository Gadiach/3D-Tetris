using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    
    private void FixedUpdate()
    {
        transform.Translate(speed, 0, 0, Space.World);
    }
}
