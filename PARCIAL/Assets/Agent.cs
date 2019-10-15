using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;


	void Start()
	{
		maxSpeed = 1f;
		maxSteer = 0.5f;

	
	}

	void Update()
	{



		 velocity += SteeringBehaviours.Seek(this, target);
		 transform.position +=velocity;


	}
}
