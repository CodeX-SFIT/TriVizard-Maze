using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 30f;
    // private Text timerSeconds;


    // Use this for initialization
    void Start()
    {
        //timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    public void Update()
    {
        timer -= Time.deltaTime;
        //timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene(LevelToLoad);
        }

    }
}
