using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInformation : MonoBehaviour
{
    [SerializeField] private InputField playerInputName;

    public string playerName = null;

    public void GoMainScene()
    {
        if (playerInputName.text.Length > 1 && playerInputName.text.Length < 11)
        {
            playerName = playerInputName.text;
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("다시 입력해주세요.");
        }
    }
}