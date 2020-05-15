using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movimiento : MonoBehaviour
{
	
	private NavMeshAgent agent;
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

			RaycastHit hitInfo;

			if (Physics.Raycast(myRay, out hitInfo))
			{
				agent.SetDestination(hitInfo.point);
			}
		}
	}
}
