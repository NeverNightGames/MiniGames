using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalResources : MonoBehaviour
{

    public BattleShip[] BattleShips;

    private GameObject[] bShipOBJ;

    public MotherShip MSScript;




    public Text TotalFoodText;

    public Text lowFoodText;


    public Text TotalEnergyText;

    public Text lowEnergyText;


    public Text TotalAmmoText;

    public Text lowAmmoText;


    //public Text TotalWeaponsText;


    public Text totalText;



    int S1Food;

    int S2Food;

    int S3Food;

    int S4Food;

    int S5Food;


    float foodTimer;



    public int totalEnergy;

    public int totalFood;

    public int totalAmmo;


    //Cycle Cyc;

    float timer;


    // private GameObject BattleShip2;



    // Use this for initialization
    void Start()
    {

        MSScript = GameObject.Find("MotherShip").GetComponent<MotherShip>();


        bShipOBJ = GameObject.FindGameObjectsWithTag("Battle Ship");




        for (int i = 0; i < bShipOBJ.Length; i++)
        {
            BattleShips[i] = bShipOBJ[i].GetComponent<BattleShip>();

        }


    }

    // Update is called once per frame
    void Update()
    {
        // Cyc = this.gameObject.GetComponent<Cycle>();

        //
        int MSEnergy = MSScript.MSEnergy;

        for (int i = 0; i < BattleShips.Length; i++)
        {
            int S1Energy = BattleShips[0].BSEnergy;

            int S2Energy = BattleShips[1].BSEnergy;

            int S3Energy = BattleShips[2].BSEnergy;

            int S4Energy = BattleShips[3].BSEnergy;

            int S5Energy = BattleShips[4].BSEnergy;

            totalEnergy = S1Energy + S2Energy + S3Energy + S4Energy + S5Energy + MSEnergy;
        }

        TotalEnergyText.text = "Energy " + totalEnergy;
        //

        if (totalEnergy <= 50)
        {
            //totalEnergy

            lowEnergyText.gameObject.SetActive(true);
        }
        else
        {
            lowEnergyText.gameObject.SetActive(false);

        }

        //
        int MSFood = MSScript.MSFood;

        for (int i = 0; i < BattleShips.Length; i++)
        {
            S1Food = BattleShips[0].BSFood;

            S2Food = BattleShips[1].BSFood;

            S3Food = BattleShips[2].BSFood;

            S4Food = BattleShips[3].BSFood;

            S5Food = BattleShips[4].BSFood;


            totalFood = S1Food + S2Food + S3Food + S4Food + S5Food + MSFood;

        }



        TotalFoodText.text = "Food " + totalFood;

        if (totalFood <= 35)
        {
            //print("LOW FOOD");

            lowFoodText.gameObject.SetActive(true);

            if (totalFood <= 0)
            {
                //print("Game Over");

                foodTimer += Time.fixedDeltaTime;

                if (foodTimer >= 15)
                {
                    Application.LoadLevel(3);
                }

                //Application.LoadLevel(3);
            }
            else
            {
                foodTimer = 0;
            }

        }
        else
        {
            lowFoodText.gameObject.SetActive(false);
        }


        //TotalFoodText.text = "Food " + totalFood;
        //

        //
        int MSAmmo = MSScript.MSAmmo;

        for (int i = 0; i < BattleShips.Length; i++)
        {
            int S1Ammo = BattleShips[0].BSAmmo;

            int S2Ammo = BattleShips[1].BSAmmo;

            int S3Ammo = BattleShips[2].BSAmmo;

            int S4Ammo = BattleShips[3].BSAmmo;

            int S5Ammo = BattleShips[4].BSAmmo;

            //totalAmmo = S1Ammo + S2Ammo + S3Ammo + S4Ammo + S5Ammo + MSAmmo;

        }

        totalAmmo = MSAmmo;

        TotalAmmoText.text = "Ammo " + totalAmmo;

        if (totalAmmo <= 50)
        {
            lowAmmoText.gameObject.SetActive(true);


        }
        else
        {
            lowAmmoText.gameObject.SetActive(false);
        }
        //

        //
        int totalAmmount = totalFood + totalEnergy + totalAmmo;

        if (totalEnergy <= 0)
        {
            timer += Time.deltaTime;

            if (timer >= 30)
            {
                Application.LoadLevel(3);
            }

            //    Debug.Log("GAME OVER");
        }
        else
        {
            timer = 0;
        }

        totalText.text = "Total: " + totalAmmount;

    }
}
