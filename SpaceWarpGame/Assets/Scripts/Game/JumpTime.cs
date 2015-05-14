using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JumpTime : MonoBehaviour {

    public float jTime;

    float timer;

    public Button jumpButton;

    private Slider jumpSlider;

	// Use this for initialization
	void Start () 
    {
        jumpSlider = GameObject.Find("Jump Slider").GetComponent<Slider>();

        jumpButton.gameObject.SetActive(false);
	
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
            
            //print("Jump");

            jumpButton.gameObject.SetActive(true);

            //timer = 0;
        }
	
	}

    public void JumpClick()
    {
        print("Jump");
    }
}

