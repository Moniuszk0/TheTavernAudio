using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public Doors door;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.ambientActivated = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            door.ambientActivated = false;
        }
        
    }
}
