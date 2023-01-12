using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent enemyNav;
    public Transform player;
    public Animator zombie;
    public ParticleSystem bloodEffect;
    public int hitCount;
    bool isAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyNav = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == true)
        {
            enemyNav.SetDestination(player.position);

            if (Vector3.Distance(player.position, gameObject.transform.position) > 5)
            {
                zombie.SetBool("walk", true);
                zombie.SetBool("run", false);
            }
            else
            {
                zombie.SetBool("walk", false);
                zombie.SetBool("run", true);
            }

            if (hitCount > 3)
            {
                zombie.SetBool("walk", false);
                zombie.SetBool("run", false);
                zombie.SetBool("injured", true);
            }
        }
        if (hitCount > 7)
        {
            Debug.Log("Died");
            zombie.SetBool("walk", false);
            zombie.SetBool("run", false);
            zombie.SetBool("injured", false);
            zombie.SetBool("die", true);
            enemyNav.enabled = false;
            isAlive = false;
            StartCoroutine(Disappear());
            this.enabled = false;   
        }
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
