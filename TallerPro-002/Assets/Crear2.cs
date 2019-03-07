using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear2 : MonoBehaviour
{
    public GameObject entidades;
    /// <summary>
    /// En el start generamos el heroe, una cantidad al azar de zombies y de aldeanos 
    /// </summary>
    void Start()
    {
        int cantidadEntidades = Random.Range(10, 21);
        int ini = 0;

        for (int i = 0; i < cantidadEntidades; i++)
        {
            int calculador = Random.Range(ini, 3);
            
            // a el heroe le agregamos sus respectivos componentes
            if (ini == 0)
            {
                ini += 1;
                entidades = GameObject.CreatePrimitive(PrimitiveType.Cube);
                entidades.name = "Heroe";
                entidades.AddComponent<Heroe>();
                entidades.AddComponent<movHeroe>();
                entidades.AddComponent<verHeroe>();
            }
            // a el zombie le agregamos sus respectivos componentes
            else if (calculador == 1)
            {
                entidades = GameObject.CreatePrimitive(PrimitiveType.Cube);
                entidades.name = "Zombie";
                entidades.AddComponent<Zombie>();
            }
            // a el aldeano le agregamos sus respectivos componentes
            else if (calculador == 2)
            {
                entidades = GameObject.CreatePrimitive(PrimitiveType.Cube);
                entidades.AddComponent<Aldeano>();
            }
        }
    }
}


