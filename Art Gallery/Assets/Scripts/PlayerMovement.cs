using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool lockMovement = false;

    public CharacterController controller;

    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        if (lockMovement) { return; }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

    public void ToggleMovementLock()
    {
        lockMovement = !lockMovement;
    }
}
