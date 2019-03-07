using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verHeroe : MonoBehaviour
{
    /// <summary>
    /// Controladores para la camara horizontal del Heroe
    /// </summary>
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Rotate(0, 2, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Rotate(0, -2, 0);
        }
    }
}
