using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BattleShipTEST : MonoBehaviour {

    public Canvas battleShipCanvas;


    public float BSFood;

    public float BSAmmo;

    public float BSEnergy;

    public int BSWeapons;


    public Slider healthBar;

    public Text energyText;

    public Text foodText;

    public Text ammoText;

    public Text weaponsText;


    private bool clickedOn;


	// Use this for initialization
	void Start () 
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
	void Update () 
    {
        energyText.text = "Energy " + BSEnergy; //Mathf.Round(BSEnergy);

        foodText.text = "Food " + BSFood;

        ammoText.text = "Ammo " + BSAmmo;

        weaponsText.text = "Weapons " + BSWeapons;
	
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

        BSEnergy += 5.0f;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       // Debug.Log("HELLO");
    }
   
}
