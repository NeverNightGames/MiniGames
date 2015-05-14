﻿using UnityEngine;
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

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
       // msAmmoText.text = "Ammo: " + MSAmmo;
	}

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
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
