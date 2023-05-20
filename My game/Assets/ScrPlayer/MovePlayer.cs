using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float SpeedMove;
    [SerializeField] private float SpeedRun;

    void Update()
    {
        MoveVertical();
        MoveHorisontal();
        Run();
    }
    
    void MoveVertical()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * SpeedMove;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition -= transform.forward * SpeedMove;
        }
    }

    void MoveHorisontal()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition -= transform.right * SpeedMove;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * SpeedMove;
        }
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localPosition += transform.forward * SpeedRun;
        }
    }

}
