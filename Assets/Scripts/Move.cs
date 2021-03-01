using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Vector3 direction;

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void DoMove(Vector3 moveValue) 
    {
        transform.Translate(moveValue);
    }

    public void SetSpeed(float value) 
    {
        speed = value;
    }

    public void SetDirection(Vector3 newDirection) 
    {
        direction = newDirection;
    }
}
