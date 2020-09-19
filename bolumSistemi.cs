using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class bolumSistemi : MonoBehaviour
{
    public Button[] lvlButtons;
    
    private void Start()
    {

        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for (int i=0;i<lvlButtons.Length;i++)
        {
            if (i + 1 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }
   

    public void levelButtonsActive(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
