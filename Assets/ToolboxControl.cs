using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolboxControl : MonoBehaviour
{
    public static bool toolboxBeingInteractedWith;  //This is made static so that it can be accessed in the player movement script
    public GameObject interactPrompt;
    public GameObject toolMenu;
    private bool inRange;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
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
        if(inRange && Input.GetKeyDown(KeyCode.E) && !toolboxBeingInteractedWith)
        {
            //Interacted With
            OpenMenu();
        }
        else if (toolboxBeingInteractedWith && Input.GetKeyDown(KeyCode.E))
        {
            CloseMenu();
        }
    }

    public void CloseMenu()
    {
        toolboxBeingInteractedWith = false;
        interactPrompt.SetActive(true);
        toolMenu.SetActive(false);
    }

    public void OpenMenu()
    {
        toolboxBeingInteractedWith = true;
        interactPrompt.SetActive(false);
        toolMenu.SetActive(true);
    }

    public void ChangeHeldTool(string newTool)
    {
        if(newTool == "Spanner")
        {
            PlayerManagment.currentTool = PlayerManagment.ToolTypes.Spanner;
        }
        else if(newTool == "Screwdriver")
        {
            PlayerManagment.currentTool = PlayerManagment.ToolTypes.Screwdriver;
        }
        else if(newTool == "Mop")
        {
            PlayerManagment.currentTool = PlayerManagment.ToolTypes.Mop;
        }
        else if(newTool == "Hammer")
        {
            PlayerManagment.currentTool = PlayerManagment.ToolTypes.Hammer;
        }
        CloseMenu();
    }
}
