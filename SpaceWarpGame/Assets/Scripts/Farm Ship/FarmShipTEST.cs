using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FarmShipTEST : MonoBehaviour {

    public Canvas farmShipCanvas;


    public float FSFood;

    public float FSAmmo;

    public float FSEnergy;

    public int FSWeapons;


    public Slider healthBar;

    public Text energyText;

    public Text foodText;

    public Text ammoText;

    public Text weaponsText;


    private bool clickedOn;



	// Use this for initialization
	void Start () 
    {
        farmShipCanvas.gameObject.SetActive(false);

        healthBar.fillRect.GetComponent<Image>().color = Color.green;

        this.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	
	}

    void OnMouseDown()
    {
        if (clickedOn == false)
        {
            farmShipCanvas.gameObject.SetActive(true);

            clickedOn = true;
        }
        else
        {
            farmShipCanvas.gameObject.SetActive(false);

            clickedOn = false;
        }
    }
    
}
