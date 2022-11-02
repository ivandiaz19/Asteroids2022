using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI vidas;
    public TextMeshProUGUI puntuacion;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo.text = Time.time.ToString("00.00"); 
        if(GameManager.instance.vidas <= 0)
        {
            GameOver.SetActive(true);
        }
    }
}
