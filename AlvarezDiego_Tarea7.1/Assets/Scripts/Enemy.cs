using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    private bool moverse = true;
    
    public GameObject waypoint1;
    public GameObject waypoint2;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {

        if (agent.remainingDistance < 0.05f)
        {
            if (moverse)
            {
                moverse = false;
                agent.SetDestination(waypoint1.transform.position);
            }
            else
            {
                moverse = true;
                agent.SetDestination(waypoint2.transform.position);
            }
        }
            




    }
    private void OnCollisionEnter(Collision collision)
    {
        // Si la pelota colsiona con las monedas, las monedas se destruyen
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
