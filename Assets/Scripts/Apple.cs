using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Apple : MonoBehaviour
{

    MeshRenderer render;
    public int moveSpeed;
    bool movement=false;
    public Transform Target;
    Vector3 current;



    private void Start()
    {
        render = GetComponent<MeshRenderer>();
        InvokeRepeating("Control", 1, 1);
        current = transform.position;
    }

    private void Control()
    {
        if(AppleTree.Instance.state==1)
        {
            render.enabled = true;
        }
        else if(AppleTree.Instance.state==2)
        {
            
            movement = true;


        }
        else
        {
            movement = false;
            transform.position = current;
            render.enabled = false;
        }
        
    }


    private void Update()
    {
        if(movement)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.position, moveSpeed * Time.deltaTime);
           
        }
        
    }
}
