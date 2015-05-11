using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BattleShipTEST : MonoBehaviour
{

    public Canvas battleShipCanvas;


    public int energyLevel;

    public int foodLevel;

    public int ammoLevel;

    public int weaponsLevel;


    public int BSEnergy;

    public int BSFood;

    public int BSAmmo;

    public int BSWeapons;


    public Slider healthBar;


    public Text energyLevelText;

    public Text foodLevelText;

    public Text ammoLevelText;

    public Text weaponsLevelText;



    public Text energyText;

    public Text foodText;

    public Text ammoText;

    public Text weaponsText;


    public bool updatedEnergy;

    public bool updatedFood;

    public bool updatedAmmo;

    public bool updatedWeapons;


    private bool clickedOn;


    // Use this for initialization
    void Start()
    {
        battleShipCanvas.gameObject.SetActive(false);

        healthBar.fillRect.GetComponent<Image>().color = Color.green;

        // healthBar.fillRect.GetComponent<Image>().color = Color.red;

    }


    void FixedUpdate()
    {
        //BSEnergy += Time.fixedDeltaTime;


        //energyText.text = "Energy " + BSEnergy; //Mathf.Round(BSEnergy);
    }

    // Update is called once per frame
    void Update()
    {
        energyText.text = "" + BSEnergy; //Mathf.Round(BSEnergy);

        foodText.text = "" + BSFood;

        ammoText.text = "" + BSAmmo;

        weaponsText.text = "" + BSWeapons;


        energyLevelText.text = "Energy LV: " + energyLevel;

        foodLevelText.text = "Food LV: " + foodLevel;

        ammoLevelText.text = "Ammo LV: " + ammoLevel;

        weaponsLevelText.text = "Weapons LV: " + weaponsLevel; 

      

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
        //print("Pressed");

       // BSEnergy = 15;

        updatedEnergy = true;

        BSEnergy -= 250;

        energyLevel += 1;

       
    }

    public void FoodUpgrade()
    {
        //print("Pressed");

      //  BSFood += 15;

        updatedFood = true;

        foodLevel += 1;
    }

    public void AmmoUpgrade()
    {
       // BSAmmo += 15;

        updatedAmmo = true;

        ammoLevel += 1;
    }

    public void WeaponsUpgrade()
    {
        weaponsLevel += 1;

        print("Weapons");
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        // Debug.Log("HELLO");
    }

}
