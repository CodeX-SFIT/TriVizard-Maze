using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupcollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //CapsuleCollider c = GetComponent<CapsuleCollider>();
	
    }


    void OnCollisionEnter(Collision collision)
    {
Application.LoadLevel("EndingWin");
    }

/*    void onCollision(CapsuleCollider c){
        Application.LoadLevel("Opening");
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
