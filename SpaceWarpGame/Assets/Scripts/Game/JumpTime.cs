using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JumpTime : MonoBehaviour
{

    public int levelCount = 1;


    public float jTime;

    float timer;


    public Button jumpButton;

    private Slider jumpSlider;


    public Material spaceMat1;


    // Use this for initialization
    void Start()
    {
        jumpSlider = GameObject.Find("Jump Slider").GetComponent<Slider>();

        jumpButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.fixedDeltaTime;

        jumpSlider.value = timer;

        //timer += Time.fixedDeltaTime;

        if (timer <= jTime)
        {
            jumpButton.gameObject.SetActive(false);

           // jumpSlider.value = timer;

        }
        else
        {
            //print("Jump"

            jumpButton.gameObject.SetActive(true);

        }
       
        //print(timer);

    }

    public void JumpClick()
    {
        levelCount++;

        jumpSlider.value = 0;

        timer = 0;

        if (levelCount == 2)
        {
            RenderSettings.skybox = spaceMat1;
        }

        if (levelCount == 3)
        {
            Application.LoadLevel(2);
        }

    }
}

