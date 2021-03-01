using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] Move moveComponent;
    [SerializeField] float speed = 3f;
    [SerializeField] Boundary boundary;

    [SerializeField] int vidas = 3;

    [SerializeField] Transform shootOrigin;
    [SerializeField] GameObject shootPrefab;

    [SerializeField] AudioClip laserShoot;

    AudioSource audioSource;

    private void Start()
    {
        moveComponent.SetSpeed(speed);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootPrefab, shootOrigin, false);
            audioSource.clip = laserShoot;
            audioSource.Play();
        }

        Vector3 move = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            transform.position.z);

        moveComponent.SetDirection(move);

        float x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
        float y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
        transform.position = new Vector3(x,y);
        
    }

    public int GetVidas() 
    {
        return vidas;
    }

    public void Damage() 
    {
        vidas--;
    }


}
