using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;    
    public float x, y;
    [SerializeField] GameObject wonScreen;

    private void Update()
    {
        MoverPlayer();
    }

    // Método para poder mover un objeto en Unity
    private void MoverPlayer()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }

    //Método para ejecutar una acción cuando exista una colisión con un objeto con una etiqueta
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Desktop")
        {
            wonScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
