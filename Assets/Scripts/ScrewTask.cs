using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrewTask : MonoBehaviour
{
    public Sprite[] boltsAndScrews;
    public Image[] images;
    public GameObject screwdriver;
    public GameObject spanner;

    private void OnEnable()
    {
        foreach(Image image in images)
        {
            image.sprite = boltsAndScrews[Random.Range(0,boltsAndScrews.Length)];
        }
        spanner.SetActive(PlayerManagment.currentTool == PlayerManagment.ToolTypes.Spanner);
        screwdriver.SetActive(PlayerManagment.currentTool == PlayerManagment.ToolTypes.Screwdriver);
    }

    private void Update()
    {
        Vector3 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector3.back * 10) + (Vector3.right * 10);
        spanner.transform.position = currentMousePos;
        screwdriver.transform.position = currentMousePos;
    }
}
