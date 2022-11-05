using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAI : MonoBehaviour
{
    [SerializeField] Vector2 lookDirection = new Vector2(1, 0);
    [SerializeField] float distance;
    GroundMoveComponent moveComponent;

    void Start()
    {
        moveComponent = GetComponent<GroundMoveComponent>();
        SetMoveVector();
    }

    void Update()
    {
        if(Physics2D.Raycast(transform.position, lookDirection, distance, ~LayerMask.GetMask("Ignore Raycast")))
        {
            lookDirection *= -1;
            SetMoveVector();
        }
    }

    void SetMoveVector()
    {
        moveComponent.MovementVector = lookDirection;
    }
}
