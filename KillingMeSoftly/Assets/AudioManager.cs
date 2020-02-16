using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class AudioManager : MonoBehaviour
{
    VisualEffect vEffect;

    public AudioClip deathSound;
    AudioSource mySource;
    float timer = 1.5f;

    private void Awake()
    {
        vEffect = GetComponent<VisualEffect>();
        mySource = GetComponent<AudioSource>();
    }

    private void Update()
    {

        if(timer < 0f)
        {
            mySource.PlayOneShot(deathSound);
            mySource.pitch = Random.Range(1f, 1.8f);
            timer = Random.Range(0.25f, 0.35f);
        }
        timer -= Time.deltaTime;
    }
}
