using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public estado zombieEstado;
    public bool mirar = false;
    public string gustoZombie;
    public int D = 0;
    public float tiempo = 0;
    public datosZombie zombieDatos = new datosZombie();

    // Se crea un enum para el gusto del zombie y se le asignan las posibles partes que puden comer
    enum partesCuerpo
    {
        Cerebros, Lenguas, Dedos, Brazos, Piernas
    }

    // Se crea un enum para los dos posibles estados del zombie
    public enum estado
    {
        idle, moving
    }

    /// <summary>
    /// En el start declaramos un rigidbody que se le asigna a la primitiva que lleva el componente de zombie;
    /// le asignamos un color al azar entre verde, cyan y magenta;
    /// le asignamos una posicion al azar en el mapa;
    /// le asignamos una tag para poder detectarlo mas facilmente
    /// </summary>
    void Start()
    {
        Rigidbody zom;
        zom = this.gameObject.AddComponent<Rigidbody>();
        zom.useGravity = false;
        zom.constraints = RigidbodyConstraints.FreezeAll;
        partesCuerpo Comer;
        Comer = (partesCuerpo)Random.Range(0, 6);
        gustoZombie = Comer.ToString();
        zombieDatos.gusto = gustoZombie;
        int numAleatorio = Random.Range(0, 3);
        this.gameObject.name = "Zombie";
        this.gameObject.tag = "Zombie";

        // en esta parte es donde asignamos el color al azar
        if (numAleatorio == 0)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            this.gameObject.transform.position = new Vector3(Random.Range(20, -21), 0, Random.Range(20, -21));
        }
        else if (numAleatorio == 1)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            this.gameObject.transform.position = new Vector3(Random.Range(20, -21), 0, Random.Range(20, -21));
        }
        else if (numAleatorio == 2)
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            this.gameObject.transform.position = new Vector3(Random.Range(20, -21), 0, Random.Range(20, -21));
        }
    }
    /// <summary>
    /// La variable tiempo es la encargada de dar la orden de que el estado zombie pueda cambiar;
    /// cumplidos los 5s la variable D se encarga de elegir que tipo de estado va a tener el zombie;
    /// 
    /// </summary>
    public void Update()
    {
        tiempo += Time.deltaTime;

        if(tiempo >= 5)
        {
            D = Random.Range(0, 2);
            mirar = true;
            tiempo = 0;
        }
        if (D == 0)
        {
            zombieEstado = estado.idle;
        }
        else if (D == 1)
        {
            zombieEstado = estado.moving;
        }
        // Dependiendo del estado asignado el zombie puede o no hacer nada en su estado IDLE o mirar a una direccion al azar y
        // moverse en su estado MOVING
        switch (zombieEstado)
        {
            case estado.idle:
                break;

            case estado.moving:                
                if (mirar)
                {
                    this.gameObject.transform.Rotate(0, Random.Range(0, 361), 0);                
                }
                this.gameObject.transform.Translate(0, 0, 0.05f);
                mirar = false;
                break;
        }
    }
}
