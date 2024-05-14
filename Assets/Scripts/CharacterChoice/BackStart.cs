using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackStart : MonoBehaviour
{
    public int character = 0;

    public void BackStartScene1()
    {
        character = 1;
        PlayerPrefs.SetInt("SeletedCharacter", 1);
        SceneManager.LoadScene("StartScene");
    }

    public void BackStartScene2()
    {
        character = 2;
        PlayerPrefs.SetInt("SeletedCharacter", 2);
        SceneManager.LoadScene("StartScene");
    }

    public void BackStartScene3()
    {
        character = 3;
        PlayerPrefs.SetInt("SeletedCharacter", 3);
        SceneManager.LoadScene("StartScene");
    }
}
