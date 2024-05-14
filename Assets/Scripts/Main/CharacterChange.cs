using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterChange : MonoBehaviour
{
    [SerializeField] private GameObject change;

    private int character;

    public void ChangeCharacter()
    {
        change.SetActive(true);
    }

    public void ReturnScene1()
    {
        character = 1;
        PlayerPrefs.SetInt("SeletedCharacter", 1);
        change.SetActive(false);
    }
    public void ReturnScene2()
    {
        character = 2;
        PlayerPrefs.SetInt("SeletedCharacter", 2);
        change.SetActive(false);
    }
    public void ReturnScene3()
    {
        character = 3;
        PlayerPrefs.SetInt("SeletedCharacter", 3);
        change.SetActive(false);
    }
}
