using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript : MonoBehaviour
{
    private InteractControl ic;
    public TaskControl.PossibleTasks task;
    public GameObject taskObject;

    private void Start()
    {
        ic = GetComponent<InteractControl>();
        taskObject.SetActive(false);
    }

    private void Update()
    {
        ic._enabled = TaskControl.currentTasks.Contains(TaskControl.PossibleTasks.VentSteam);
        if(ic.inRange && Input.GetKeyDown(KeyCode.E))
        {
            taskObject.SetActive(true);
        }
    }

    public void CloseTask()
    {
        taskObject.SetActive(false);
    }
}
