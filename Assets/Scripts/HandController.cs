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
        actionTrigger.action.canceled += TriggerRelease;

        actionGrip.action.performed += GripPress;
        actionGrip.action.canceled += GripRelease;

        handAnimator = GetComponent<Animator>();
    }

    private void GripPress(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }

    private void GripRelease(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Grip", 0);
    }

    private void TriggerPress(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void TriggerRelease(InputAction.CallbackContext obj)
    {
        handAnimator.SetFloat("Trigger", 0);
    }

    private void OnDestroy()
    {
        actionTrigger.action.performed -= TriggerPress;
        actionTrigger.action.canceled -= TriggerRelease;

        actionGrip.action.performed -= GripPress;
        actionGrip.action.canceled -= GripRelease;
    }
}
