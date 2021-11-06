using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewTask : MonoBehaviour
{
    private InteractControl ic;

    private void Start()
    {
        ic = GetComponent<InteractControl>();
    }
}
