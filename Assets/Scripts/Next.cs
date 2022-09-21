using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public Button yourButton;
    public AudioClip Sound;
    private AudioSource myAudioSource;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        SceneManager.LoadScene(7);
    }
    void Update()
    {
       
    }
 }
    

