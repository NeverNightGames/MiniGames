using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TESTTotal : MonoBehaviour {

    public Text totalText;

    public int TotalEnergy;

    public TESTShip TShip1;

    public TESTShip TShip2;

	// Use this for initialization
	void Start ()
    {
        TShip1 = GameObject.Find("Ship 1 Text").GetComponent<TESTShip>();

        TShip2 = GameObject.Find("Ship 2 Text").GetComponent<TESTShip>();

	
	}
	
	// Update is called once per frame
	void Update () 
    {

        TotalEnergy = TShip1.SEnergy + TShip2.SEnergy;

        totalText.text = "" + TotalEnergy;


	
	}
}
