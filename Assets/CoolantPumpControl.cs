using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolantPumpControl : MonoBehaviour
{
    private InteractControl ic;

    private void Start()
    {
        ic = GetComponent<InteractControl>();
    }

    private void Update()
    {
        if(ic.inRange && Input.GetKeyDown(KeyCode.E))
        {
            //Interacted With
            PlayerManagment.currentTool = PlayerManagment.ToolTypes.Bucket;
        }
    }
}
