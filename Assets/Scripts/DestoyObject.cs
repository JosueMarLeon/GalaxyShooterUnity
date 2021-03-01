using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyObject : MonoBehaviour
{
    [SerializeField] float destroyTime = 1f;

    public void DoDestroy() 
    {
        Destroy(gameObject,destroyTime);
    }
}
