using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TMP_Text scoreText;        
    [SerializeField] private int score;
    [SerializeField] private GameObject table;
        
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    
    void Update()
    {
        scoreText.text = score.ToString("0");
        TurnOnTable();
    }
    
    //M�todo para realizar una resta de n�meros enteros
    public void sumarPuntos(int puntos)
    {
        score -= puntos;        
    }

    //M�todo para activar un objeto despu�s de cumplirse con la condici�n del s�
    public void TurnOnTable()
    {
        if(score == 0) 
        { 
            table.gameObject.SetActive(true);
        }
    }

}
