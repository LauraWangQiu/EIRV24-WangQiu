using UnityEngine.InputSystem;
using UnityEngine;

public class ActivarLinterna : MonoBehaviour
{
    [SerializeField] InputActionReference activateAction;
    [SerializeField] Light spotlight;

    private void Start()
    {
        spotlight = GetComponent<Light>();
    }

    private void Update()
    {
        float a = activateAction.action.ReadValue<float>();
        spotlight.intensity = a * 5;
    }
}
