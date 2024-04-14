using System.Diagnostics;
using UnityEngine;

public class InteractableObjectScript : MonoBehaviour
{
    public bool isInteractable = true;

    void Interact()
    {
        if (isInteractable)
        {
            // Perform interaction logic here
            Debug.Log("Object interacted!");
        }
    }
}
