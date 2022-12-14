using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class GamePanel : MonoBehaviour
{
    /// <summary>
    /// 总得分Text
    /// </summary>
    public TextMeshProUGUI totalScoreText;
    /// <summary>
    /// home按钮
    /// </summary>
    public Button homeBtn;

    /// <summary>
    /// 总得分
    /// </summary>
    private int m_totalScore;

    public GameObject m_gamePass;  //設定 GAME PASS　物件
    public GameObject m_timer;

    public AudioClip PassSound;
    public AudioClip Sound;
    public bool isStop=false;
    public Timer timer;
    private AudioSource myAudioSource;

    private void Awake()
    {

        homeBtn.onClick.AddListener(() =>
        {
            // Home按钮被点击，进入Login场景
            SceneManager.LoadScene(0);
        });

        // 注册加分事件
        EventDispatcher.instance.Regist(EventDef.EVENT_ADD_SCORE, OnAddScore);
    }

    private void OnDestroy()
    {
        // 注销加分事件
        EventDispatcher.instance.UnRegist(EventDef.EVENT_ADD_SCORE, OnAddScore);
    }

    /// <summary>
    /// 加分事件
    /// </summary>
    private void OnAddScore(params object[] args)
    {
        // 更新总分显示
        m_totalScore += (int)args[0];
        totalScoreText.text = m_totalScore.ToString();
    }
    private void Start()
    {
        // StartCoroutine(Pass());
    }

    void Update()
    {
        myAudioSource = GetComponent<AudioSource>();
        if (!isStop)
        {
            if (m_totalScore >= 1000)
            {
                timer.Timeup();
                isStop = true;
                myAudioSource.PlayOneShot(PassSound);
                m_gamePass.SetActive(true);
                //SceneManager.LoadScene(2);

            }
        }

    }
}
   // private IEnumerator Pass()


