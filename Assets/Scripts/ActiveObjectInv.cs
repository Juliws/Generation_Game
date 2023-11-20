using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ActiveObjectInv : MonoBehaviour
{
    [SerializeField] GameObject objetc;
    [SerializeField] GameObject image;
    [SerializeField] GameObject panel;
    [SerializeField] private AudioClip sonidoPunto;
    [SerializeField] private int cantidad;
    [SerializeField] private Score puntaje;

    //Método para ejecutar una acción cuando exista una colisión con un objeto con una etiqueta
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundsControl.Instance.Playsound(sonidoPunto);
            image.SetActive(true);
            panel.SetActive(false);
            puntaje.sumarPuntos(cantidad);
            Destroy(gameObject);
        }

    }
}
