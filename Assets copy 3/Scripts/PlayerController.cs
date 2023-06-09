using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    private Animator animator;
    
 
    void Start()
    {
        animator=GetComponent<Animator>();
    }
  void Update()
  {
    if(Input.GetMouseButtonDown(1))
    {
        Ray movePosition=Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(movePosition,out var hitInfo))
        {
            agent.SetDestination(hitInfo.point);
            animator.SetBool("isMoving",true);
        }
    }
  }
}
