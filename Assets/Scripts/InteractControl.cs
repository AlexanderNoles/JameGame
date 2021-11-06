using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractControl : MonoBehaviour
{
    public GameObject interactPrompt;
    [HideInInspector]
    public bool inRange;
    public bool _enabled = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && _enabled)
        {
            inRange = true;
            interactPrompt.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = false;
            interactPrompt.SetActive(false);
        }
    }

    private void Update()
    {
        if (!_enabled)
        {
            inRange = false;
            interactPrompt.SetActive(false);
        }
    }
}
