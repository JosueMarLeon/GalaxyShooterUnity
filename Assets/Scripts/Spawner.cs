using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    public void DoInstantiate() 
    {
        DoInstantiate(transform.position);
    }

    public void DoInstantiate(Vector3 thePosition)
    {
        Instantiate(prefab, thePosition, transform.rotation);
    }
}
