using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuGearsRotate : MonoBehaviour
{
    public GameObject gear;
    public int direction;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        gear.transform.Rotate(0, 0, direction);
    }
}
