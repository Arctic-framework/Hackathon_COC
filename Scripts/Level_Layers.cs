using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Layers : MonoBehaviour
{
    public int ID;

    public Grid_Render G_R;

    public int GID;
    public MeshRenderer self_MR;

    public bool Rich;
    public Material Rich_Mat;
    public bool Poor;
    public Material Poor_Mat;

    public bool Floodplane;
    public Material Floodplane_Mat;

    public bool forest;
    public Material Forest_Material;

    public bool correct;
    public Material Correct_Material;

    public bool Wrong;
    public Material Wrong_Material;

    public bool Hidden;




    public bool Render_Wealth;

    public bool Render_Correct;

    public bool Render_forest;

    public bool Render_FloodPlane;

    public bool Render_Water;

    public int level;

    public GameObject floor;











    // Start is called before the first frame update
    void Start()
    {
        Hidden = true;
        self_MR = GetComponent<MeshRenderer>();
        floor = GameObject.FindGameObjectWithTag("Floor");
        G_R = floor.GetComponent<Grid_Render>();
    }

    // Update is called once per frame
    void Update()
    {

        GID = G_R.array_number;

        if (GID == 1)
        {
            Render_Wealth = true;
            Hidden = false;
        }
        else
        {
            if (GID == 2)
            {
                Render_Correct = true;
                Hidden = false;
            }
            else
            {
                if (GID == 3)
                {
                    Render_forest = true;
                    Hidden = false;
                }
                else
                {
                    if (GID == 4)
                    {
                        Render_FloodPlane = true;
                        Hidden = false;
                    }
                    else
                    {
                        if (GID == 5)
                        {
                            Render_Water = true;
                            Hidden = false;
                        }
                        else
                        {
                            Debug.Log("something_Went_Wrong");
                        }
                    }
                }

            }

        }

















        if (Hidden == true)
        {
            self_MR.enabled = false;
        }
        else
        {
            self_MR.enabled = true;
        }




        if (level == 1)
        {
            if (Render_FloodPlane == true)
            {
                if (Floodplane == true)
                {
                    self_MR.material = Floodplane_Mat;
                }
            }

            if (Render_forest == true)
            {
                if (Render_forest == true)
                {
                    self_MR.material = Forest_Material;
                }
            }

            if (Render_Wealth == true)
            {
                if (Poor == true)
                {
                    self_MR.material = Poor_Mat;
                }
                if (Rich == true)
                {
                    self_MR.material = Rich_Mat;
                }
            }

            if (Render_Water == true)
            {
                if (Wrong == true)
                {
                    self_MR.material = Wrong_Material;
                }
                if (correct == true)
                {
                    self_MR.material = Correct_Material;
                }
            }
        }












    }
}
