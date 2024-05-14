using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public SpriteRenderer renderer;

    private Animator animator;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Start()
    {
        int character = PlayerPrefs.GetInt("SeletedCharacter");
        if (character == 1)
        {
            Debug.Log(character);
            renderer.sprite = sprite1;
            animator.SetInteger("New Int", 1);
        }
        else if (character == 2)
        {
            Debug.Log(character);
            renderer.sprite = sprite2;
            animator.SetInteger("New Int", 2);
        }
        else
        {
            Debug.Log(character);
            renderer.sprite = sprite3;
            animator.SetInteger("New Int", 3);
        }
    }
}
