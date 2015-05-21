using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BattleShip : MonoBehaviour
{

    public Canvas battleShipCanvas;


    //public int energyLevel;

    //public int foodLevel;

    //public int ammoLevel;

    //public int weaponsLevel;


    public int BSEnergy;

    public int BSFood;

    public int BSAmmo;

    public int BSWeapons;


    // public int upgradeCost = 250;

    public bool updatedEnergy;

    public bool updatedFood;

    public bool updatedAmmo;

    public bool updatedWeapons;



    public Slider healthBar;


    public Text energyText;

    public Text foodText;

    public Text ammoText;

    public Text weaponsText;

    public Vector2 colPos;


    private bool clickedOn;

    public Texture2D cursorTexture;
    CursorMode cursorMode = CursorMode.Auto;
    Vector2 hotSpot = Vector2.zero;


    // Use this for initialization
    void Start()
    {
        battleShipCanvas.gameObject.SetActive(false);

        healthBar.fillRect.GetComponent<Image>().color = Color.green;

        // healthBar.fillRect.GetComponent<Image>().color = Color.red;

    }


    // Update is called once per frame
    void Update()
    {

        energyText.text = "" + BSEnergy; //Mathf.Round(BSEnergy);

        foodText.text = "" + BSFood;

        ammoText.text = "" + BSAmmo;

        weaponsText.text = "" + BSWeapons;




        healthBar.fillRect.GetComponent<Image>().color = Color.green;

        if (healthBar.value <= 50 && healthBar.value >= 26)
        {
            healthBar.fillRect.GetComponent<Image>().color = Color.yellow;
        }
        else if(healthBar.value <= 25)
        {
            healthBar.fillRect.GetComponent<Image>().color = Color.red;
        }

        if(healthBar.value <= 1)
        {
            //print("Battle Ship Gone");

            this.gameObject.SetActive(false);

            BSEnergy -= 250;

            BSFood -= 125;

            BSAmmo -= 100;
        }
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
        //print("Pressed");

        if (clickedOn == false)
        {
            battleShipCanvas.gameObject.SetActive(true);

            clickedOn = true;
        }
        else
        {
            battleShipCanvas.gameObject.SetActive(false);

            clickedOn = false;
        }

    }

    public void EnergyUpgrade()
    {
        updatedEnergy = true;
    }

    public void FoodUpgrade()
    {


        updatedFood = true;
    }

    public void AmmoUpgrade()
    {
        // BSAmmo += 15;

        updatedAmmo = true;


    }

    public void WeaponsUpgrade()
    {

        print("Weapons");
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy Bullet")
        {
            healthBar.value--;

            colPos = col.gameObject.transform.position;

            print(colPos);
        }
    }

}
