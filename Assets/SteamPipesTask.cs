using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamPipesTask : MonoBehaviour
{
    private InteractControl ic;

    private void Start()
    {
        ic = GetComponent<InteractControl>();
    }
}
