using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour
{
    // hacemos dos referencias a dos scripts para poder llamarlos en este script
    public Zombie z;
    public Aldeano a;

    /// <summary>
    /// Le damos un nombre para diferenciarlo mas facil en scena, lo ubicamos en un lugar aleatorio;
    /// le agregamos en componente rigidbod, desactivamos la gravedad, activamos el freez en todos sus lados y le agregamos ;
    /// el componente camara;
    /// /// le asignamos una posicion al azar en el mapa
    /// </summary>
    void Start()
    {
        Rigidbody her;
        this.gameObject.name = "Heroe";
        this.gameObject.transform.position = new Vector3(Random.Range(-20, 21), 0, Random.Range(-20, 21));
        her = this.gameObject.AddComponent<Rigidbody>();
        her.useGravity = false;
        her.constraints = RigidbodyConstraints.FreezeAll;
        this.gameObject.AddComponent<Camera>();       
    }

    public void OnCollisionEnter(Collision collision)
    {       
        /// si este game object coliciona con otro que tenga la tag Aldeano, va a imprimir por consola los respectivos datos del Aldeano
        if (collision.gameObject.tag == "Aldeano")
        {
            a = collision.gameObject.GetComponent<Aldeano>();
            Debug.Log("Hola soy " + a.villagerData.nombre + " y tengo " + a.villagerData.edad + " años");
        }
        /// si este game object coliciona con otro que tenga la tag Zombie, va a imprimir por consola los respectivos datos del Zombie
        if (collision.gameObject.tag == "Zombie")
        {
            z = collision.gameObject.GetComponent<Zombie>();
            Debug.Log("Waaaarrrr quiero comer " + z.zombieDatos.gusto);

        }
    }
}
