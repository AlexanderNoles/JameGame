using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolantTask : MonoBehaviour
{
    public Image coolant;
    public Image errorMessage;
    private bool complete;

    private void OnEnable()
    {
        coolant.rectTransform.localPosition = new Vector3(525, 0);
        complete = PlayerManagment.currentTool == PlayerManagment.ToolTypes.Bucket;
        errorMessage.gameObject.SetActive(!complete);
    }

    private void Update()
    {
        if (complete)
        {
            coolant.rectTransform.localPosition = Vector3.Lerp(coolant.rectTransform.localPosition, new Vector3(525, 300), Time.deltaTime * 5);
            TaskControl.currentTasks.Remove(TaskControl.PossibleTasks.Coolant);
            if(coolant.rectTransform.localPosition.y > 290)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
