using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{   
    
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;
    Vector3 steer = Vector3.zero;
    float maxSpeed= 5;
    float maxSteer = 5;

    int Radius = 1;
    Transform Target;
    [SerializeField]
    private Transform tar;
    bool IsEnter = false; 

    

    void Update()
    {
        
        Mover();
        Kill();
        Extra();
    }

    void Mover()
    {
        Target=GameObject.Find("Target").transform;

        //Desired
        desired = (transform.position-Target.transform.position).normalized*maxSpeed;

        //Steer
        steer= Vector3.ClampMagnitude(desired-velocity, maxSteer);
        velocity += steer*Time.deltaTime;
        transform.position += velocity*Time.deltaTime;
    }

    void Kill(){
        float distance = (tar.position - transform.position).magnitude;
        Debug.Log(distance);
        if(distance <=Radius)
        {
            
        if (!IsEnter)
            {
                IsEnter = true;
                print("Entró");
                Destroy(gameObject);
            } 
        }
        else
        {
            if (IsEnter)
            {
                IsEnter = false;
            }
        }
    }

    void Extra(){
         if(transform.position.y < -4.5f){
           Destroy(gameObject);
           print("Te fuiste muy lejos");
        }

        if(transform.position.x <-9.5f){
            Destroy(gameObject);
            print("Te fuiste muy lejos");
        }

        if(transform.position.x > 9.5f){
            Destroy(gameObject);
            print("Te fuiste muy lejos");
        }

        if(transform.position.y > 4.5f){
            Destroy(gameObject);
            print("Te fuiste muy lejos");
        }

    }
}
