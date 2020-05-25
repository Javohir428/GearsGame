using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 20;
    public Animator transition;
    public GameObject Panel;
    public AudioSource audioData;
    public AudioSource music;
    bool takingAway = false;
    bool timeStop = false;
    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        //audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0 && timeStop == false)
        {
            StartCoroutine(TimerTake());
        }
    }

    public void StopTime()
    {
        timeStop = true;
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        if (secondsLeft == 0)
        {
            audioData.Pause();
            music.Play();
            Panel.SetActive(true);
            transition.SetTrigger("run");
        }
        takingAway = false;
    }
}
