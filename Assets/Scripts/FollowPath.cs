using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    Transform goal; //Goal from A* algorithm
    float speed = 5.0f;          //Velocidad del tanque
    float accuracy = 1.0f;		 //Distancia por debajo de la cual considero que he alcanzado el nodo
    float rotSpeed = 2.0f;       //Velocidad de rotacion del tanque
    public GameObject wpManager; //All the graph points and links
    GameObject[] wps;            //Nodos del grafo
    GameObject currentNode;		 //El nodo mas cercano en cada momento
    int currentWP = 0;           //Indice a lo largo del camino que seguimos, no tiene que ver con el numero/posicion de cada WP
    Graph g;                     //Grafo

    // Start is called before the first frame update
    void Start()
    {
        //Inicializar wps, g y currentNode
    }

    public void GoToHeli()
    {
    }

    public void GoToRuin()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Testear si no hay un camino definido (empty path) o currentWP esta ya al final del camino

        //Guardamos en currentNode el nodo que tenemos mas cercano en este momento

        //Si estamos suficientemente cerca al nodo currentWP, pasamos a buscar el siguiente

        //Si aun no hemos llegado al final del camino, nos dirigimos al siguiente nodo
		//if (...) {
			//Guardamos en goal el nuevo nodo a visitar

			//Miramos hacia nuestro destino (goal)

            //Movemos el tanque

        //}

        g.debugDraw();

    }
}
