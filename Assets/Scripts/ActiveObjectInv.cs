using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveObjectInv : MonoBehaviour
{
    [SerializeField] GameObject objetc;
    [SerializeField] GameObject image;
    [SerializeField] GameObject Panel;
    [SerializeField] private AudioClip sonidopunto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundsControl.Instance.Playsound(sonidopunto);
            Destroy(gameObject);
            image.SetActive(true);
            Panel.SetActive(false);
        }

    }
}
