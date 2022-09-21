using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
    public GameObject m_skip;
    public GameObject m_skippanel;
    private float m_delay;
    // Start is called before the first frame update
    void Start()
    {
        m_skip.SetActive(false);
        m_skippanel.SetActive(false);
        m_delay = Time.time + 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_delay < Time.time)
        {
            delayfunc();
        }
    }
    private void delayfunc()
    {
        m_skip.SetActive(true);
    }

    public void OnClick_skip()
    {
        m_skippanel.SetActive(true);
    }
    public void OnClick_yes()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnClick_yes2()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnClick_yes3()
    {
        SceneManager.LoadScene("passbook");
    }
    public void OnClick_no()
    {
        m_skippanel.SetActive(false);
    }

}

