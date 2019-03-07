using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movHeroe : MonoBehaviour
{
    public float Velocidad;

    void Start()
    {
        // Velocidad aleatoria del heroe
        Velocidad = Random.Range(0.05f, 0.1f);
    }
    /// <summary>
    /// Controladores para el movimiento en Z del Heroe
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(0, 0, Velocidad);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(0, 0, -Velocidad);
        }
    }
}
