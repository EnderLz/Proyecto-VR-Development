using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSounds : MonoBehaviour
{

    [SerializeField] public AudioSource audioSource;
    [SerializeField] private List<AudioClip> audios = new List<AudioClip>();
    [SerializeField] private float delayMin = 2f;
    [SerializeField] private float delayMax = 50f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(PlaySounds());
    }

    IEnumerator PlaySounds()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(delayMin, delayMax));
            var selectedAudio = audios[Random.Range(0, audios.Count)];
            audioSource.clip = selectedAudio;
            audioSource.Play();
        }
    }
}
