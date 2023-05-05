using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float xMouseSensitivity=100f;
    public Transform playerBody;
  
    float xRotation=0f;
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.Confined; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
             Cursor.lockState = CursorLockMode.None;
        }
        //Get position of mouse
        float mouseX = Input.GetAxis("Mouse X")* xMouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")* xMouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        //Can't rotate behind
        xRotation= Mathf.Clamp(xRotation, -90f, 90f);
        //Rotate player with the camera
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
