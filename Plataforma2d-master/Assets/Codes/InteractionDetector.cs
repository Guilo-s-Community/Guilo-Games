using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
public class InteractionDetector : MonoBehaviour
{
    private IInteragivel interactableInRange = null;
    public GameObject interactionIcon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactionIcon.SetActive(false);
    }

    public void OnInteract()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            interactableInRange?.Interact();
        }
    }

    private void OnTriggerEnter2d(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteragivel interactable) && interactable.CanInteract())
        {
            interactableInRange = interactable;
            interactionIcon.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteragivel interactable) && interactable == interactableInRange)
        {
            interactableInRange = null;
            interactionIcon.SetActive(false);
        }
    }

    void Update()
    {
        OnInteract();
    }
}

