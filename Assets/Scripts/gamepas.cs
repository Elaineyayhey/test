using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamepas : MonoBehaviour
{
    public AudioClip PassSound;
    private AudioSource myAudioSource;
    public GameObject m_gamePass;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource.PlayOneShot(PassSound);
        m_gamePass.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
