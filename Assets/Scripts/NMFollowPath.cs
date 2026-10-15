using UnityEngine;
using UnityEngine.AI;

public class NMFollowPath : MonoBehaviour
{
    public Transform helipad;       //Destino: Helipuerto
    public Transform ruins;         //Destino: Ruinas
    public Transform oilStorage;    //Destino: Almacen Petroleo

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void GoToHeli()
    {
        agent.SetDestination(helipad.position);
    }

    public void GoToRuin()
    {
        agent.SetDestination(ruins.position);
    }

    public void GoToOil()
    {
        agent.SetDestination(oilStorage.position);
    }

    void Update()
    {
        Vector3[] corners = agent.path.corners;
        
        for (int i = 0; i < corners.Length - 1; i++)
            Debug.DrawLine(corners[i], corners[i + 1], Color.red);
    }
}
