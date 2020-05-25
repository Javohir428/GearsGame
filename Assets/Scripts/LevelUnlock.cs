using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlock : MonoBehaviour
{
    int CurrentLevel;
    private void Start() 
    {
        CurrentLevel = PlayerPrefs.GetInt("ReachLevel", 1);
    }

    public void GoNextLevel(int SceneIndex)
    {
        if(CurrentLevel == SceneIndex)
        {
            PlayerPrefs.SetInt("ReachLevel", CurrentLevel + 1);
        }


    }

}
