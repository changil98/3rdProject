using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCharacterChoice : MonoBehaviour
{
    public void GoCharacterChoiceScene()
    {
        SceneManager.LoadScene("CharacterChoiceScene");
    }
}
