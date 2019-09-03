using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ABCD : MonoBehaviour
{

    private VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
     	player = GetComponent<VideoPlayer>();
player.loopPointReached += EndReached;    }

    // Update is called once per frame
    void Update()
    {
        
    }

void EndReached(VideoPlayer vp){
Application.LoadLevel("SampleScene");
}
}
