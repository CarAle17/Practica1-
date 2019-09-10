using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    [SerializeField]
    private int Radius =1;


    

    void OnDrawGizmos(){
        Gizmos.color=Color.cyan;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
}
