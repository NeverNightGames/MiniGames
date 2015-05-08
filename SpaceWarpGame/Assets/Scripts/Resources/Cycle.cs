using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cycle : MonoBehaviour
{

    float timer;

    public float cycleTime;

    public int cycle;

    public Text cycleText;


	// Use this for initialization
	void Start () 
    {
        //print("TEST");
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        timer += Time.fixedDeltaTime;

        if (timer >= cycleTime)
        {
            cycle += 1;

            timer = 0;
        }

        cycleText.text = "Cycle " + cycle;

        

        


	
	}
}
