using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lockImageDisable : MonoBehaviour
{
    public Transform button;
     public Image img;
    // Start is called before the first frame update

     void Start () 
     {
        img.enabled = true;
     }

    // Update is called once per frame
    void Update()
    {

        if (button.GetComponent<Button>().IsInteractable() == true)
        {
            img.enabled = false;
        } else
        {
            img.enabled = true;
        }
    }
}
