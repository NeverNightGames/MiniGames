using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MotherShipTest : MonoBehaviour {

   // public Canvas motherShipCanvas;


    public int MSEnergy;

    public int MSFood;

    public int MSAmmo;

    public int MSWeapons;

    public Text msAmmoText;

    private bool Clicked = false;


	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        msAmmoText.text = "Ammo: " + MSAmmo;
	}

    void OnMouseDown()
    {
        //print("clicked");

        if (Clicked == false)
        {
          

            Clicked = true;
        }
        else if (Clicked == true)
        {
           

            Clicked = false;
        }
    }
}
