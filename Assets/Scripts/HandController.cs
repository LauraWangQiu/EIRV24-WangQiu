using UnityEngine.InputSystem;
using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField] InputActionReference actionGrip;
    [SerializeField] InputActionReference actionTrigger;
    private Animator handAnimator;

    private void Start()
    {
        actionTrigger.action.performed += TriggerPress;
        actionGrip.action.performed += GripPress;
        handAnimator = GetComponent<Animator>();
    }

    private void GripPress(InputAction.CallbackContext obj)
    {
        Debug.Log("Sellama");
        handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }
    private void TriggerPress(InputAction.CallbackContext obj)
    {
        Debug.Log("Sellama");
        handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }
}
