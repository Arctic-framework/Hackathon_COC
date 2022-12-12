using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_Location : MonoBehaviour
{
    public int ID;
    public int Building_At_Id;
    public int Array_List;
    public bool Wrong;
    // Start is called before the first frame update
    void Start()
    {
        Array_List = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Array_List <= 15)
        {
            Array_List++;
            ID = Array_List;
        }
        else
        {
            Array_List = 0;
        }
        if (ID == 1)
        {
            if (Building_At_Id == 1 )
            {
                Wrong = true;
            }
        }
    }
}
