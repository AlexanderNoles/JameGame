using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskControl : MonoBehaviour
{
    public float timeBetweenTask = 10f;
    private float timeLeft;
    public enum PossibleTasks
    {
        Tighten,
        Coolant,
        VentSteam,
        Dials,
        Clean,
        Fixing
    }
    public static List<PossibleTasks> currentTasks = new List<PossibleTasks>(); //Add a task to this list when it needs to be completed
                                                                                //(don't add two of the same task to the list, because then the task will have to be completed twice)
    private void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            timeLeft = timeBetweenTask;
            while (true)
            {
                PossibleTasks newTask = (PossibleTasks)Random.Range(0, 5);
                if (!currentTasks.Contains(newTask))
                {
                    currentTasks.Add(newTask);
                    break;
                }
            }
        }
    }
}
