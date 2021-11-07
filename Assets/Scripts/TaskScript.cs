using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript : MonoBehaviour
{
    private InteractControl ic;
    public TaskControl.PossibleTasks task;
    public GameObject icon;
    public GameObject taskObject;   //This should control the specific task through "OnEnable" and "OnDisable"

    private void Start()
    {
        ic = GetComponent<InteractControl>();
        //taskObject.SetActive(false);
        icon.SetActive(false);
    }

    private void Update()
    {
        ic._enabled = TaskControl.currentTasks.Contains(task);
        icon.SetActive(ic._enabled);
        if(ic.inRange && Input.GetKeyDown(KeyCode.E))
        {
            taskObject.SetActive(!taskObject.activeSelf);
        }
    }

    public void CloseTask()
    {
        taskObject.SetActive(false);
    }
}
