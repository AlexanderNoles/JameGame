using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialstask : MonoBehaviour
{
    public GameObject dialsPanelObj;
    public RectTransform[] dialSliders;
    public RectTransform[] dialTargets;
    public RectTransform[] dialHitboxes;

    Vector2 _PANEL_HEIGHT_RANGE = new Vector2(-124, 58);

    public void OnStartTask() {
        dialsPanelObj.SetActive(true);
        
        foreach (RectTransform slider in dialSliders) {
            slider.localPosition = new Vector2(slider.localPosition.x, -122.2f);
        }

        foreach (RectTransform target in dialTargets) {
            target.localPosition = new Vector2(target.localPosition.x, Random.Range(_PANEL_HEIGHT_RANGE.x, _PANEL_HEIGHT_RANGE.y));
        }
    }

    private void Update() {
        if (dialsPanelObj.activeInHierarchy) {
            Collider2D c = Physics2D.OverlapPoint(Input.mousePosition);

            if (c != null && c.gameObject.tag == "DIAL" && Input.GetButton("Fire1")) {
                Vector2 dir = Input.mousePosition - c.gameObject.transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                c.gameObject.transform.eulerAngles = Vector3.forward * angle;
            }
        }
    }

    private void Start() {
        OnStartTask();
    }
}
