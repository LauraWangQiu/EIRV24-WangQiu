using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateInOnce : MonoBehaviour
{
    [SerializeField]
    private float rotationAmount_;

    public void OnButtonTriggered()
    {
        transform.Rotate(Vector3.up, rotationAmount_);      
    }
    public void OnButtonNotTriggered()
    {
        transform.Rotate(Vector3.up, -rotationAmount_);
    }
}
