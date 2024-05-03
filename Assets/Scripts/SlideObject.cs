using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SlideObject : MonoBehaviour
{
    [SerializeField]
    private Transform sliderTr_;
    [SerializeField]
    private float minZ_;
    [SerializeField]
    private float maxZ_;

    private bool isTriggering_ = false;
    private Vector3 initialPos_;
    
    private XRBaseInteractable interactable_;
    private float zOffset_;

    public void Start()
    {
        initialPos_ = sliderTr_.localPosition;
        interactable_ = GetComponent<XRBaseInteractable>();
        interactable_.hoverEntered.AddListener(OnTriggerEntered);
        interactable_.hoverExited.AddListener(OnTriggerExited);
    }

    public void OnTriggerEntered(BaseInteractionEventArgs interactor)
    {
        zOffset_ = interactable_.transform.position.z - sliderTr_.position.z;
        interactable_.hoverEntered.AddListener(MoveSlider);
    }

    public void OnTriggerExited(BaseInteractionEventArgs interactor)
    {
        interactable_.hoverExited.RemoveListener(MoveSlider);
    }

    private void MoveSlider(BaseInteractionEventArgs interactor)
    {
        Vector3 newPosition = sliderTr_.localPosition;
        newPosition.z = sliderTr_.position.z ;
        sliderTr_.localPosition = newPosition;
    }
}
