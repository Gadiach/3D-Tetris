using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollision : MonoBehaviour
{        
    private Rigidbody rbd;
    
    private void Start()
    {       
        rbd = GetComponent<Rigidbody>();      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {             
                rbd.constraints = RigidbodyConstraints.None;                                           
        }        
    }
}
