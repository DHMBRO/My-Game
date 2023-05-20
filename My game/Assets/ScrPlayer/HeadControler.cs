using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadControler : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;

    [SerializeField] private float Sens;

    private float MouseX;
    private float MouseY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RotateHead();
        RotatePlayer();
    }
    
    void RotateHead()
    {
        MouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-MouseY * Sens, 0.0f, 0.0f));
    }

    void RotatePlayer()
    {
        MouseX = Input.GetAxis("Mouse X");
        PlayerTransform.transform.Rotate(new Vector3(0.0f, MouseX * Sens, 0.0f));
    }

}
