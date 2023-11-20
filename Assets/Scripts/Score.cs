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
    
    public void sumarPuntos(int puntos)
    {
        score -= puntos;        
    }

    public void TurnOnTable()
    {
        if(score == 0) 
        { 
            table.gameObject.SetActive(true);
        }
    }

}
