using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JumpTime : MonoBehaviour {

    public int levelCount = 1;

    public float jTime;

    float timer;

    public Button jumpButton;

    private Slider jumpSlider;


    public GameObject backOBJ;

    private SpriteRenderer backSprRender;

    public Sprite[] backSPR;

	// Use this for initialization
	void Start () 
    {
        jumpSlider = GameObject.Find("Jump Slider").GetComponent<Slider>();

        jumpButton.gameObject.SetActive(false);

        backSprRender = backOBJ.GetComponent<SpriteRenderer>();

        backSprRender.sprite = backSPR[0];
	
	}

    // Update is called once per frame
    void Update() 
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

        levelCount++;

        if (levelCount == 2)
        {
            backSprRender.sprite = backSPR[1];

            timer = 0;
        }

       // backSPR.sprite = 
    }
}

