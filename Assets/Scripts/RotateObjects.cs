using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed_;

    private bool isTriggered_ = false;

    public void OnTriggerEntered()
    {
        isTriggered_ = true;
    }

    public void OnTriggerExited()
    {
        isTriggered_ = false;
    }

    private void Update()
    {
        if (isTriggered_)
        {          
            transform.Rotate(Vector3.up * rotationSpeed_ * Time.deltaTime);
        }
    }
}
