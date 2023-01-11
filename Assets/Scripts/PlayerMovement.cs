using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Audios")]
    public AudioSource footstepSounds;
    public AudioSource shootingSounds;
    public AudioClip[] shootingClips;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            footstepSounds.enabled = true;
            Debug.Log("Play");
        }
        else
        {
            footstepSounds.enabled = false;
        }
    }

    public void PlayerShooting(int _clip)
    {
        shootingSounds.clip = shootingClips[_clip];
        shootingSounds.Play();
    }
}
