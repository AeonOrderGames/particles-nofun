using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSens = 100f;

    public Transform leBody;

    float xRot = 0f;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        leBody.Rotate(Vector3.up * mouseX);
    }
}
