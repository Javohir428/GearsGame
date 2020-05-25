using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject gear;
    public GameObject gears;
    public int direction;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (gears.activeSelf)
        {
            gear.transform.Rotate(0, 0, direction);
        }
    }
}
