using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectArea : MonoBehaviour
{
    bool detected;
    public GameObject shootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(detected)
        {
            //Debug.Log("Target in range");
            AIShoot();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            detected = true;
        }
    }

    void AIShoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(shootPoint.transform.position,shootPoint.transform.forward,out hit))
        {
            Debug.Log(hit.transform.gameObject.name);
        }
    }
}
