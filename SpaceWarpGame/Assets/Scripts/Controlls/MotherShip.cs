using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MotherShip : MonoBehaviour {

   // public Canvas motherShipCanvas;


    public int MSEnergy;

    public int MSFood;

    public int MSAmmo;

    public int MSWeapons;

    public Text msAmmoText;

    public bool Clicked = false;

    Turret theTurret;

    public Slider MSHealthBar;

    Quaternion turRot;

    public Texture2D cursorTexture;
    public Texture2D cursorTexture1;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 hotSpot = Vector2.zero;

	// Use this for initialization
	void Start () 
    {
        theTurret = GameObject.Find("MS Gun 1").GetComponent<Turret>();

        turRot = new Quaternion(this.gameObject.transform.rotation.x, this.gameObject.transform.rotation.y, this.gameObject.transform.rotation.z, this.gameObject.transform.rotation.w);
	

	}
	
	// Update is called once per frame
	void Update () 
    {
        MSHealthBar.fillRect.GetComponent<Image>().color = Color.green;

        if (MSHealthBar.value <= 250 && MSHealthBar.value >= 130)
        {
            MSHealthBar.fillRect.GetComponent<Image>().color = Color.yellow;
        }
        else if (MSHealthBar.value <= 125)
        {
            MSHealthBar.fillRect.GetComponent<Image>().color = Color.red;
        }

        if (MSHealthBar.value <= 1)
        {
            print("Game Over");

            Application.LoadLevel(3);
        }
      
	}

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture1, hotSpot, cursorMode);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
    
    void OnMouseDown()
    {
        print("clicked");

        if (Clicked == false)
        {
            theTurret.canFire = true;

            Clicked = true;
        }
        else if (Clicked == true)
        {
            this.gameObject.transform.rotation = turRot;

            theTurret.canFire = false;

            Clicked = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy Bullet")
        {
            MSHealthBar.value--;
        }

    }
}
