using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;
    private bool isDoorOpen = false;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleDoor();
        }
    }

    public void ToggleDoor()
    {
        if (!isDoorOpen)
        {
            isDoorOpen = true;
            animator.SetBool("isOpen", isDoorOpen);
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
