using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent enemy;
    public Transform player;
    public Animator zombie;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemy = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);

        if(Vector3.Distance(player.position,gameObject.transform.position)>5)
        {
            zombie.SetBool("walk", true);
            zombie.SetBool("run", false);
            Debug.Log("Its fucking far");
        }
        else
        {
            zombie.SetBool("walk", false);
            zombie.SetBool("run", true);
            Debug.Log("Its fucking close");
        }
    }
}
