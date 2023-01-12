using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public CinemachineVirtualCamera cam;
    public ParticleSystem muzzleFlash;

    [Header("Scripts")]
    public PlayerMovement playerMovement;
    public EnemyMovement enemyMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        playerMovement.PlayerShooting(0);       //0 array clip is for gun shooting
        muzzleFlash.Play();
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            if (hit.transform.gameObject.CompareTag("Enemy"))
            {
                enemyMovement.bloodEffect.Play();
                Debug.Log(hit.transform.gameObject.name);
            }
        }
    }
}
