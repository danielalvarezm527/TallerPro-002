using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldeano : MonoBehaviour
{
    public int edad;
    public string nombreAldeano;
    public datosAldeano villagerData = new datosAldeano();

    // declaramos un enum publico que nos va a almacenar los nombres que deseamos que aparezcan
    enum Nombre
    {
        Daniel, Julio, Sebastian, Santiago, Alex, Danilo, Luis, Juan, Anderson, Cristian, Alejandro, Kevin, Jorge, Felipe, David, Natalia, Camila, Monica, Andrea, Carolina
    }
    /// <summary>
    /// En el start declaramos un rigidbody que se le asigna a la primitiva que lleva el componente de aldeano;
    /// le asignamos un nombre al azar del enum;
    /// le asignamos una edad al azar del 15 al 100;
    /// le asignamos una posicion al azar en el mapa;
    /// le asignamos una tag para poder detectarlo mas facilmente
    /// </summary>
    void Start()
    {
        Rigidbody ald;
        ald = this.gameObject.AddComponent<Rigidbody>();
        ald.useGravity = false;
        ald.constraints = RigidbodyConstraints.FreezeAll;
        Nombre nombres;
        nombres = (Nombre)Random.Range(0, 21);
        nombreAldeano = nombres.ToString();
        edad = Random.Range(15, 101);
        villagerData.nombre = nombreAldeano;
        villagerData.edad = edad.ToString();
        this.gameObject.tag = "Aldeano";
        this.gameObject.transform.position = new Vector3(Random.Range(20, -21), 0, Random.Range(20, -21));
        this.gameObject.name = villagerData.nombre;
    }

}
