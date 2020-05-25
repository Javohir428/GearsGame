using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPopUp : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 0.30f;
    public GameObject Panel;
    public AudioSource audioData;

    public void WinPanel()
    {
        Panel.SetActive(true);
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(transitionTime);
        transition.SetTrigger("run");
        audioData.Play();
    }
}
