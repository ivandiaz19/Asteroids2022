using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AsteroidManager : MonoBehaviour
{
    public int asteroides_min = 4;
    public int asteroides_max = 8;
    public int asteroides;
    public float limiteY = 6;
    public float limiteX = 11;
    public GameObject asteroide;
    // Start is called before the first frame update
    void Start()
    {
        CrearAsteroides();
    }

    // Update is called once per frame
    void Update()
    {
       if (asteroides <= 0)
        {
            asteroides_min += 2;
            asteroides_max += 2;
            CrearAsteroides();
        }
       
    }

    void CrearAsteroides()
    {
        int asteroides = Random.Range(asteroides_min, asteroides_max);

        for (int i = 0; i < asteroides; i++)
        {
            Debug.Log("Instanciando asteroide: " + i);
            Vector3 posicion = new Vector3(Random.Range(-limiteX, limiteX), Random.Range(-limiteY, limiteY));

            while(Vector3.Distance(posicion, new Vector3(0,0)) < 2)
            {
                posicion = new Vector3(Random.Range(-limiteX, limiteX), Random.Range(-limiteY, limiteY));
            }

            Vector3 rotacion = new Vector3(0, 0, Random.Range(0f, 360f));
            GameObject temp = Instantiate(asteroide, posicion, Quaternion.Euler(rotacion));
            temp.GetComponent<AsteroidController>().manager = this;
        }

    }
}
