using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Creamos una estructura para facilitar la entrada de datos en nuestro grafo
[System.Serializable]
public struct Link //Edge entre nodos
{
    public enum direction { UNI, BI }; //Edge de una direccion o bidireccional
    public GameObject node1;
    public GameObject node2;
    public direction dir;
}

public class GraphManager : MonoBehaviour
{
    public GameObject[] waypoints;    //Array de waypoints
    public Link[] links;              //Array de links
    public Graph graph = new Graph(); //Codigo para el grafo esta ya creado en la carpeta "Graphs"

    void Start()
    {
        //Si waypoints tiene nodos definidos
        if(waypoints.Length > 0){

            //Iteramos cada WP y lo guardamos en graph
            foreach (GameObject wp in waypoints){
                graph.AddNode(wp);
            }

            //Iteramos cada Link y lo guardamos en graph
            foreach(Link l in links){
                graph.AddEdge(l.node1, l.node2);
                if(l.dir == Link.direction.BI)
                    graph.AddEdge(l.node2, l.node1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        graph.debugDraw();
    }

    void OnDrawGizmos()
    {
        graph.debugDraw();
    }
}
