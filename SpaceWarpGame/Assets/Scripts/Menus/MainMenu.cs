using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Canvas menuCanvas;

    public Canvas creditsCanvas;



	// Use this for initialization
	void Start () 
    {
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
