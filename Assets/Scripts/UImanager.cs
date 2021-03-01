using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] Text enemigos;
    [SerializeField] Text vidas;
    [SerializeField] Text puntos;
    [SerializeField] GameObject gameOver;

    int puntuacion;
    private void Start()
    {
        puntuacion = 0;
        enemigos.text = puntuacion.ToString();
        vidas.text = FindObjectOfType<PlayerController>().GetVidas().ToString();
        gameOver.SetActive(false);
    }

    private void Update()
    {
        if (FindObjectOfType<PlayerController>().GetVidas() >= 0) 
        {
            vidas.text = FindObjectOfType<PlayerController>().GetVidas().ToString();
            puntos.text = puntuacion.ToString();

            if (FindObjectOfType<Spawner>() != null) 
            {
                enemigos.text = FindObjectsOfType<Spawner>().Length.ToString();
            }
            
        }
        if (FindObjectOfType<PlayerController>().GetVidas() <= 0)
        {
            gameOver.SetActive(true);
        }

    }

    public void SetPuntuacion(int puntos) 
    {
        puntuacion += puntos;
    }


}
