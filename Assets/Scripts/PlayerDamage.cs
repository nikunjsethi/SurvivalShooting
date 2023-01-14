using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerDamage : MonoBehaviour
{
    public Image healthHurt;
    public Image healthBar;
    public AudioSource _playerInjuredAudio;
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
