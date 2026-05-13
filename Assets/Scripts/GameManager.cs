using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public static bool gameOver = false;

    public float tiempo = 0f;

    void Update()
    {
    if(GameManager.gameOver == false)
    {
        tiempo += Time.deltaTime;

        timerText.text = tiempo.ToString("F2");
    }
}
    
}