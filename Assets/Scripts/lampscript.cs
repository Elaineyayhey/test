using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lampscript : MonoBehaviour
{

    public Button PauseButton;
    public GameObject PauseWindow;
    public GameObject m_extext;
    public GameObject m_extext2;
    public GameObject m_gameplay;
    public GameObject m_exbutton;
    public GameObject m_backmenu;
    public GameObject m_nextbutton;
    public GameObject m_pageup;
    public GameObject m_gobackbutton;
    public Button homeBtn;
    private bool isPause;
    // Start is called before the first frame update
    void Start()
    {
        isPause = false;
        PauseButton.onClick.AddListener(PauseGame);
        PauseWindow.SetActive(false);
        m_extext.SetActive(false);
        m_extext2.SetActive(false);
        m_nextbutton.SetActive(false);
        m_pageup.SetActive(false);
        m_gameplay.SetActive(false);
        m_gobackbutton.SetActive(false);
    }

    // Update is called once per frame
    void PauseGame()
    {
        isPause = !isPause;

        if (isPause == true)
        {
            PauseButton.image.sprite = Resources.Load<Sprite>("Sprites/resume");
            PauseWindow.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PauseButton.image.sprite = Resources.Load<Sprite>("Sprites/pause");
            PauseWindow.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Oncclick_lamp()
    {
        PauseWindow.SetActive(true);
    }
    public void Oncclick_extext()
    {
        m_extext.SetActive(true);
        m_exbutton.SetActive(false);
        m_backmenu.SetActive(false);
        m_nextbutton.SetActive(true);
    }
    public void Oncclick_nextbutton()
    {
        m_extext.SetActive(false);
        m_nextbutton.SetActive(false);
        m_pageup.SetActive(true);
        m_extext2.SetActive(true);
        m_gameplay.SetActive(true);
        m_gobackbutton.SetActive(false);
    }

    public void Oncclick_pageup()
    {
        m_pageup.SetActive(false);
        m_nextbutton.SetActive(true);
        m_extext.SetActive(true);
        m_extext2.SetActive(false);
        m_gameplay.SetActive(false);
        m_gobackbutton.SetActive(true);
    }

    public void Oncclick_gobackbutton()
    {
        m_exbutton.SetActive(true);
         m_backmenu.SetActive(true);
        m_extext.SetActive(false);
        m_nextbutton.SetActive(false);
        m_gobackbutton.SetActive(false);
    }

    //private void Awake()
    //{

    //    homeBtn.onClick.AddListener(() =>
    //    {

    //        SceneManager.LoadScene(0);
    //    });


    //}

    public void Oncclick_backmenu()
    {
        SceneManager.LoadScene(0);
    }
}
