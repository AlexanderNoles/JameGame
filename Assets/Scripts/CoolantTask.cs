using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolantTask : MonoBehaviour
{
    private InteractControl ic;

    private void Start()
    {
        ic = GetComponent<InteractControl>();
    }
}
