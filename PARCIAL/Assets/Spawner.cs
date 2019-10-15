using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
    public GameObject A;
    public GameObject B;
    public GameObject queso;
   
   
    float timer = 0;
    float timer2 = 0;
     public float TIMEA = 3f;
     public float TIMEB = 5f;
   

    //Seek
   
   
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

    
     



       


        if(timer >= TIMEA){
            timer = 0;
            Action();
        }

        if(timer2 >= TIMEB){
              timer2 = 0;
            Action2();


        }



        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
    }

    

    void Action(){
     Instantiate(A,queso.transform.position,Quaternion.identity);
    }

    void Action2(){
        Instantiate(B,queso.transform.position,Quaternion.identity);
    }
}