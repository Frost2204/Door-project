using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    public Animator doorAnimator; // Reference to the Animator
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if Player enters
        {
            doorAnimator.SetBool("isOpen", true); // Open door
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if Player exits
        {
            doorAnimator.SetBool("isOpen", false); // Close door
        }
    }
}
