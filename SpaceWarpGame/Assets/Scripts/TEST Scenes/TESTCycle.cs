using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TESTCycle : MonoBehaviour
{

    float timer;

    public float CycleTime;

    public int cycle;

    private Text cycleText;

    public TESTTotal TTotal;

    // Use this for initialization
    void Start()
    {
        cycleText = this.gameObject.GetComponent<Text>();

        TTotal = GameObject.Find("Manager").GetComponent<TESTTotal>();

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.fixedDeltaTime;

        if (timer >= CycleTime)
        {
            TTotal.TShip1.SEnergy -= 100;

            if (TTotal.TShip1.Updated == false)
            {
                TTotal.TShip1.SEnergy += 50;
            }
            else if (TTotal.TShip1.Updated == true)
            {
                TTotal.TShip1.SEnergy += 150;
            }

            cycle += 1;

            timer = 0;

        }

        print(timer);



        cycleText.text = "" + cycle;

    }
}
