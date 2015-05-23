using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controls : MonoBehaviour {

    public Texture2D mouseCurs;

    CursorMode cursorMode = CursorMode.Auto;

    Vector2 hotSpot = Vector2.zero;

	// Use this for initialization
	void Start () 
    {
        //Cursor.visible(false);
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           // Application.Quit();

            Application.LoadLevel(0);

           // print("QUIT");
        }
	
	}

    void OnUI()
    {
       print("Button");
    }

    //void OnMouseEnter()
    //{
    //    Cursor.SetCursor(mouseCurs, hotSpot, cursorMode);
    //}
    //void OnMouseExit()
    //{
    //    Cursor.SetCursor(null, Vector2.zero, cursorMode);
    //}

}
