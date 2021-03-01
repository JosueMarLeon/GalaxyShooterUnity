using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(collision.gameObject);

        if (collision.gameObject.tag == "PlayerShoot") 
        {
            if (gameObject.tag == "Enemy") 
            {
                GetComponent<Spawner>().DoInstantiate();
            }

            FindObjectOfType<UImanager>().SetPuntuacion(1);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            if (FindObjectOfType<PlayerController>().GetVidas() > 0) 
            {
                FindObjectOfType<PlayerController>().Damage();
            }
            else 
            {
                Destroy(collision.gameObject);
            }
            if (gameObject.tag == "Enemy")
            {
                GetComponent<Spawner>().DoInstantiate();
            }
            Destroy(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }


    }
}
