using System.Diagnostics;
using UnityEngine;

public class EventTriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Perform event trigger logic here
            Debug.Log("Event triggered!");
        }
    }
}
