using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerDamage : MonoBehaviour
{
    public Image healthHurt;
    public Image healthBar;
    public AudioSource _playerInjuredAudio;
    bool wave1,wave2,wave3;
    private void Start()
    {
        healthHurt = GameObject.Find("InjuredEffect").GetComponent<Image>();
        healthBar = GameObject.Find("HealthBar").GetComponent<Image>();
        _playerInjuredAudio = GameObject.FindGameObjectWithTag("PlayerBody").GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(healthBar.fillAmount==0)
        { 

        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerBody"))
        {
            StartCoroutine(PlayerHurt());
        }
    }

    IEnumerator PlayerHurt()
    {
        healthHurt.enabled = true;
        _playerInjuredAudio.Play();
        healthBar.fillAmount = healthBar.fillAmount - 0.1f;
        yield return new WaitForSeconds(3f);
        healthHurt.enabled = false;
    }
}
