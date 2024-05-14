using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameChange : MonoBehaviour
{
    [SerializeField] private GameObject change;
    [SerializeField] private InputField playerInputName;

    public string playerName;

    public void ChangeUI()
    {
        change.SetActive(true);
    }

    public void ReturnScene()
    {
        if (playerInputName.text.Length > 1 && playerInputName.text.Length < 11)
        {
            playerName = playerInputName.text;
            PlayerPrefs.SetString("Name", playerName);
            change.SetActive(false);
        }
    }
}
