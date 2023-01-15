using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemyInstantiation : MonoBehaviour
{
    public GameObject[] enemies;
    GameObject[] enemyInstantiations = new GameObject[200];
    public Transform[] instantiatingPoints;
    public TextMeshProUGUI waveNo;
    public bool nextWave = false;
    [Header("Other Scripts")]
    [SerializeField] private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy = Instantiate(enemies[Random.Range(0,enemies.Length)], instantiatingPoints[Random.Range(0,instantiatingPoints.Length)]);
        waveNo.text = "Wave 1";
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.timerWave == 2)
        {
            if (nextWave == false)
            {
                waveNo.text = "Wave 2";
                for (int i = 0; i < 2; i++)
                    enemyInstantiations[i] = Instantiate(enemies[Random.Range(0, enemies.Length)], instantiatingPoints[Random.Range(0, instantiatingPoints.Length)]);
                nextWave = true;
            }
        }
        else if (timer.timerWave == 3)
        {
            if (nextWave == false)
            {
                waveNo.text = "Wave 3";
                for (int i = 0; i < 4; i++)
                    enemyInstantiations[i] = Instantiate(enemies[Random.Range(0, enemies.Length)], instantiatingPoints[Random.Range(0, instantiatingPoints.Length)]);
                nextWave = true;
            }
        }

        else if (timer.timerWave == 4)
        {
            if (nextWave == false)
            {
                waveNo.text = "Wave 4";
                for (int i = 0; i < 8; i++)
                    enemyInstantiations[i] = Instantiate(enemies[Random.Range(0, enemies.Length)], instantiatingPoints[Random.Range(0, instantiatingPoints.Length)]);
                nextWave = true;
            }
        }
    }
}
