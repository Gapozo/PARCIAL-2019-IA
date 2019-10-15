using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : SBAgent
{

     public GameObject target;
     public GameObject[] targets;
  
    

  
    // Start is called before the first frame update

    void Awake(){
       
    }
    void Start()
    {
        maxSpeed = 2f;
		maxSteer = 0.5f;
        targets = GameObject.FindGameObjectsWithTag("B");

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
        velocity += SteeringBehaviours.Seek(this, target.transform);
        velocity += SteeringBehaviours.Separate(this, targets, 4f);
       

       transform.position +=velocity * Time.deltaTime;

        
        
    }
}
