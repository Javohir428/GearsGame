using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManagerLoader : MonoBehaviour
{
    Button[] levelButtons;
    public Animator transition;
    public float transitionTime = 1f;

    int fromNum;
    int toNum;
 
    public void fromNumber(int from)
    {
        fromNum = from;
    }
    
    public void toNumber(int to)
    {
        toNum = to;
    }

    private void Awake() 
    {
        //PlayerPrefs.DeleteAll();
        int ReachLevel = PlayerPrefs.GetInt("ReachLevel", 1);

        levelButtons = new Button[transform.childCount];

        for (int i = 0; i < levelButtons.Length; i++)
        {
            levelButtons[i] = transform.GetChild(i).GetComponent<Button>();

            if (i + 1 > ReachLevel)
            {
                levelButtons[i].interactable = false;
            }
        }
        
    }

    public void SceneLoader()
    {
        StartCoroutine(LoadLevel(Random.Range(fromNum, toNum)));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
