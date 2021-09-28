using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    [Header("Player Controller")]
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] MouseLook mouseLook;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            playerMovement.ToggleMovementLock();
            mouseLook.ToggleCameraLock();
        }
    }
}
