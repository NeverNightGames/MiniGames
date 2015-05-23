using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JumpTime : MonoBehaviour {

    public int levelCount = 1;

    public float jTime;

    float timer;

    public Button jumpButton;

    private Slider jumpSlider;

    public Material spaceMat1;


   // public GameObject backOBJ;

   // private SpriteRenderer backSprRender;



    public Sprite[] backSPR;

	// Use this for initialization
	void Start () 
    {
        jumpSlider = GameObject.Find("Jump Slider").GetComponent<Slider>();

        jumpButton.gameObject.SetActive(false);

        //backSprRender = backOBJ.GetComponent<SpriteRenderer>();

       // backSprRender.sprite = backSPR[0];
	
	}

    // Update is called once per frame
    void Update() 
    {

        jumpSlider.value = timer;

        if (timer <= jTime)
        {
            timer += Time.fixedDeltaTime;

            jumpButton.gameObject.SetActive(false);
        }
        else
        {
            //print("Jump"

            jumpButton.gameObject.SetActive(true);

            this.gameObject.GetComponent<EnemyWave>().timerToAttack = 2;

            //if (levelCount == 1)
            //{
            //    this.gameObject.GetComponent<EnemyWave>().timerToAttack = 2;
            //}

           // timer = 0;
        }
	
	}

    public void JumpClick()
    {
        //print("Jump");

        levelCount++;

        if (levelCount == 2)
        {
           // backSprRender.sprite = backSPR[1];

            this.gameObject.GetComponent<EnemyWave>().timerToAttack = 120;

            timer = 0;
        }

        if (levelCount == 3)
        {
            Application.LoadLevel(2);
        }

        RenderSettings.skybox = spaceMat1;

       // backSPR.sprite = 
    }
}

