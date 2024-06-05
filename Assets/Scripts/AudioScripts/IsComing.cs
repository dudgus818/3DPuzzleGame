using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsComing : MonoBehaviour
{
    public AudioClip[] monstercoming;
    public AudioSource monstercomeSource;
    public float iscomingRate;
    private float iscomingTime;

    // Start is called before the first frame update
    void Start()
    {
        monstercomeSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (monstercomeSource == null)
            return;

        if (Time.time - iscomingTime > iscomingRate)
        {
            iscomingTime = Time.time;
            monstercomeSource.PlayOneShot(monstercoming[Random.Range(0, monstercoming.Length)]);
        }
    }
}
