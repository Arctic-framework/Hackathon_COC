using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gridder : MonoBehaviour
{
    public Transform self;
    public int ID;

    public Building_Location BL;

    public int Building_ID;

    public Transform building1;
    public Transform building2;
    public Transform building3;
    public Transform building4;
    public Transform building5;
    public Transform building6;
    public Transform building7;
    public Transform building8;
    public Transform building9;
    public Transform building10;
    public Transform building11;
    public Transform building12;
    public bool Operation_Is_Done;
    public Ipad_Grab  I_G;



    public TextMesh TM;

    public bool Wrong;

    public bool Snapped;

    public bool Close_Enough;
    public bool Disabled_Spot;
    public Vector3 Location;



    public bool Wrong_Hi;
    public bool Wrong_Me;
    public bool Wrong_Lo;

    public bool Wrong_Reasoning_Water;
    public bool Wrong_Reasoning_Poor;
    public bool Wrong_Reasoning_Swamp;
    public bool Wrong_Reasoning_Rich;

    public bool scaler;

    [Header("This is the messgae that is displayed when the player puts the wrong house on this tile")]
    public string Wrong_Messege;
    public string Correct_Messege;




    // Start is called before the first frame update
    void Start()
    {
        self = GetComponent<Transform>();
        Location = self.position;
        TM.text = "Wow nothing has gone wrong yet";
    }

    // Update is called once per frame
    void Update()
    {
        Building_ID = 0;
        Snapped = false;




        Disabled_Spot = false;
        Close_Enough = false;
        if (Vector3.Distance(self.position, building1.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 1;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building2.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 2;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building3.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 3;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building4.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 4;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building5.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 5;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building6.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 6;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }
        if (Vector3.Distance(self.position, building7.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 7;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building8.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 8;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building9.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 9;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building10.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 10;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building11.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 11;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }

        if (Vector3.Distance(self.position, building12.position) < .1)
        {
            Close_Enough = true;
            Building_ID = 12;
        }
        if (Close_Enough == true)
        {
            Disabled_Spot = true;
        }
        Wrong = false;
        if (1 == 1)
        {
            if (Wrong_Me == true)
            {
                if (Building_ID == 1)
                {
                    Wrong = true;
                }
                if (Building_ID == 4)
                {
                    Wrong = true;
                }
                if (Building_ID == 8)
                {
                    Wrong = true;
                }
                if (Building_ID == 7)
                {
                    Wrong = true;
                }
            }
            if (Wrong_Hi == true)
            {

                if (Building_ID == 3)
                {
                    Wrong = true;
                }
                if (Building_ID == 4)
                {
                    Wrong = true;
                }
                if (Building_ID == 10)
                {
                    Wrong = true;
                }
                if (Building_ID == 9)
                {
                    Wrong = true;
                }

            }
            if (Wrong_Lo == true)
            {
                if (Building_ID ==6)
                {
                    Wrong = true;
                }
                if (Building_ID == 2)
                {
                    Wrong = true;
                }
                if (Building_ID == 11)
                {
                    Wrong = true;
                }
                if (Building_ID == 12)
                {
                    Wrong = true;
                }
            }
            if (Wrong == true)
            {
                if (Operation_Is_Done == false)
                {
                    TM.text = Wrong_Messege;
                    Operation_Is_Done = true;
                    I_G.money = I_G.money - 50;
                }
                if (Random.Range(0, 500) == 1)
                {
                    if (Wrong_Reasoning_Water == true)
                    {
                        scaler = true;
                    }
                    if (Wrong_Reasoning_Swamp == true)
                    {
                        scaler = true;

                    }
                    if (Wrong_Reasoning_Poor == true)
                    {
                        scaler = true;
                    }
                }
            }
            if (Wrong == false)
            {
                if (Close_Enough == true)
                {
                    if (Operation_Is_Done == false)
                    {
                        TM.text = Correct_Messege;
                        Operation_Is_Done = true;
                    }
                }
            }
        }
    }
}
