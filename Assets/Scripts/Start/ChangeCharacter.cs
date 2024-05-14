using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCharacter : MonoBehaviour
{
    public Image img;

    public Sprite img1;
    public Sprite img2;
    public Sprite img3;

    public void Start()
    {
        int character = PlayerPrefs.GetInt("SeletedCharacter");
        if(character == 1)
        {
            Debug.Log(character);
            img.sprite = img1;
        }
        else if(character == 2)
        {
            Debug.Log(character);
            img.sprite = img2;
        }
        else
        {
            Debug.Log(character);
            img.sprite = img3;
        }
    }
}
