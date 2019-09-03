using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end1 : MonoBehaviour
{
    //public string LevelToLoadg5;
    //public string LevelToLoadl5;
    private float timer = 300f;
    //public float timer1=0f;
    public Text timerSeconds;


    // Use this for initialization
    void Start()
    {
       //timerSeconds = GetComponent<Text>();
    }
    /*void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(LevelToLoadl5);
        timer1 = timer;
    }*/
    // Update is called once per frame
    public void Update()
    {
        timer -=Time.deltaTime;
        int minutes = (int)(timer / 60);
        int seconds = (int)(timer % 60);
        timerSeconds.text = (minutes).ToString("0")+(":")+(seconds).ToString("00");
        if (timer <= 0)
        {
            SceneManager.LoadScene("EndingBefore");
        }
       

    }
}
