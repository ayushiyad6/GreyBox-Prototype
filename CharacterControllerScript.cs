using System.Numerics;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public CharacterController controller;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 move = transform.right * moveDirection.x + transform.forward * moveDirection.z;

    }
}
