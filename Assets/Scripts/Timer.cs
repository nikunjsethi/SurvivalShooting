using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timerBar;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 10f;
        timerBar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);
            timerBar.fillAmount = (timerBar.fillAmount - Time.deltaTime * 0.1f);
        }
        else
        {
            timer = 10;
            timerBar.fillAmount = 1;
        }
        
    }
}
