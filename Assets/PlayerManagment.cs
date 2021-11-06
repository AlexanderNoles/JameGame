using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagment : MonoBehaviour
{
    public enum ToolTypes
    {
        Spanner,
        Screwdriver,
        Mop,
        Hammer,
        Bucket
    }
    public static ToolTypes currentTool;
}
