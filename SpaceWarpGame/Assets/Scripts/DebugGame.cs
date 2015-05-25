using UnityEngine;
using System.Collections;

public class DebugGame : MonoBehaviour {

    JumpTime JT;



	// Use this for initialization
	void Start () 
    {
        JT = this.gameObject.GetComponent<JumpTime>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            JT.levelCount++;


        }
	
	}
}
