using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfrontOrBehind : MonoBehaviour
{
    private SpriteRenderer sr;
    public float relativePassPoint;
    public GameObject player; //This should be changed to a static instance once the player movement is implemented

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (player.transform.position.y > transform.position.y + relativePassPoint)
        {
            sr.sortingLayerName = "Infront";
        }
        else
        {
            sr.sortingLayerName = "Behind";
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(new Vector3(transform.position.x - 5, transform.position.y + relativePassPoint, 0), 
            new Vector3(transform.position.x + 5, transform.position.y + relativePassPoint, 0));
    }
}
