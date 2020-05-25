using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlashLight : MonoBehaviour, IDragHandler
{
    public GameObject flashlight;
    public RectTransform reactTransform;
  
    private void Awake()
    {
        reactTransform = GetComponent<RectTransform>();
    }

    void LateUpdate()
    {
        Vector3 clampedPosition =  reactTransform.anchoredPosition;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -227f, 227f);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -640f, 640f);
        reactTransform.anchoredPosition = clampedPosition;

        Vector3 clampedPosition2 = flashlight.transform.position; 
        clampedPosition2.x = Mathf.Clamp(clampedPosition2.x, -2, 2f);  
        clampedPosition2.y = Mathf.Clamp(clampedPosition2.y, -5.5f, 5.5f);
        flashlight.transform.position = clampedPosition2;

    }

    public void OnDrag(PointerEventData eventData)
    {
        reactTransform.anchoredPosition += eventData.delta;                                                  
        flashlight.transform.position += new Vector3(eventData.delta.x * 0.009f, eventData.delta.y * 0.009f, 0);
    }
    
}