using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(NavMeshAgent))]
public class Movment : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform[] patrolPoints;
    public int currentindex;
    public EnumStates currentstate;
    private float currentTime;
    public float maxtimetowait = 2f;
    public Transform personaje;
    public int Enemy_Damage = 20;
    public GameObject prueba;
    public Playeritems personaje_ref;
    public Animator animator;

    public enum EnumStates
    {
        patrol,
        wait,
        chase,
        attak,
        DEAD
    }

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    private void GotoNextpoint()
    {
        animator.SetBool("Walking", true);
        currentindex++;

        if (currentindex >= patrolPoints.Length)
        {
            currentindex = 0;
        }
        agent.SetDestination(patrolPoints[currentindex].position);
    }

    void Start()
    {

        gameObject.SetActive(true);
        GotoNextpoint();
    }

    private void Update()
    {
        switch (currentstate)
        {
            case EnumStates.patrol:
                animator.SetBool("Walking", true);
                prueba.SetActive(false);
                if (agent.remainingDistance < 1)
                {
                    currentTime = 0;
                    currentstate = EnumStates.wait;
                }
                break;
            case EnumStates.wait:
                animator.SetBool("Walking", false);
                prueba.SetActive(false);
                currentTime += Time.deltaTime;
                if (currentTime > maxtimetowait)
                {
                    GotoNextpoint();

                    currentstate = EnumStates.patrol;
                }
                break;
            case EnumStates.chase:
                animator.SetBool("Walking", true);
                prueba.SetActive(true);
                agent.SetDestination(personaje.position);
                if (agent.remainingDistance < 1)
                {
                    currentTime = 0;
                    currentstate = EnumStates.attak;
                }
                break;
            case EnumStates.attak:
                SceneManager.LoadScene(personaje_ref.night_num);
                if (agent.remainingDistance > 1)
                {
                    currentTime = 0;
                    currentstate = EnumStates.chase;
                }
                break;
        }
    }
}
