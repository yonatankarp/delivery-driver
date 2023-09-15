using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Package")) {
            Debug.Log("Package picked up");
        } else if(other.CompareTag("Customer")) {
            Debug.Log("Package delivered");
        }
    }
}
