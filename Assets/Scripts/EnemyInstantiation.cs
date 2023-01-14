using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemyInstantiation : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] instantiatingPoints;
    public TextMeshProUGUI waveNo;
    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy = Instantiate(enemies[Random.Range(0,enemies.Length)], instantiatingPoints[Random.Range(0,instantiatingPoints.Length)]);
        waveNo.text = "Wave 1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
