using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Canvas menuCanvas;

    public Canvas controlsCanvas;

    public Canvas creditsCanvas;


	// Use this for initialization
	void Start () 
    {

        controlsCanvas.gameObject.SetActive(false);

        creditsCanvas.gameObject.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayPress()
    {
       // print("Pressed");

        Application.LoadLevel(1);
    }

    public void QuitPress()
    {
        // print("Pressed");

        Application.Quit();
    }

    public void ControlsPress()
    {
        menuCanvas.gameObject.SetActive(false);

        controlsCanvas.gameObject.SetActive(true);
    }

    public void ControlsQuit()
    {
        controlsCanvas.gameObject.SetActive(false);

        menuCanvas.gameObject.SetActive(true);
    }


    public void CreditsPress()
    {
        menuCanvas.gameObject.SetActive(false);

        creditsCanvas.gameObject.SetActive(true);
    }

    public void CreditsQuit()
    {
        menuCanvas.gameObject.SetActive(true);

        creditsCanvas.gameObject.SetActive(false);
    }
}
