using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text textName;
    [SerializeField] private Text time;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        textName.text = playerName;
    }

    private void Update()
    {
        GetCurrentDate();
        ChangeName();
    }

    private void GetCurrentDate()
    {
        string DayTime = DateTime.Now.ToString("T");
        time.text = DayTime;
    }

    private void ChangeName()
    {
        string playerName = PlayerPrefs.GetString("Name");
        textName.text = playerName;
    }
}
