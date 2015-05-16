using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
}
