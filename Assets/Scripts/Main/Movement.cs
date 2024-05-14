using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Rigidbody2D movementRigidbody;

    [SerializeField] private SpriteRenderer characterRenderer;

    private Vector2 movementDirection = Vector2.zero;
    private Vector2 seeDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        controller.OnLookEvnent += See;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
        RotateSee(seeDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }

    private void See(Vector2 direction)
    {
        RotateSee(direction);
        seeDirection = direction;
    }

    private void RotateSee(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }
}
