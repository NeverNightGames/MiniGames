using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JumpTime : MonoBehaviour {

    public float jTime;

    float timer;

    private Slider jumpSlider;

	// Use this for initialization
	void Start () 
    {
        jumpSlider = GameObject.Find("Jump Slider").GetComponent<Slider>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        jumpSlider.value = timer;

        if (timer <= jTime)
        {
            timer += Time.fixedDeltaTime;
        }
        else
        {
            print("Jump");

            //timer = 0;
        }
	
	}
}

