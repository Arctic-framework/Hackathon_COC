using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable_Script : MonoBehaviour
{
    public Transform self_position;
    public Transform Right_Hand_Position;
    public Transform Left_Hand_Position;
    public bool Right_Hand_Left_Hand;
    public MeshRenderer MR_self;
    public bool Close_Enough;
    public VR_API VAPI;
    public bool Locked_On_Left;
    public bool Locked_On_Right;
    public int ID;
    public bool Activated;
    public bool Disabled_Left;
    public bool Disabled_Right;
    public bool Grab_Or_Empty;
    public int grabby;
    public Transform grid_1;
    public Transform grid_2;
    public Transform grid_3;
    public Transform grid_4;
    public Transform grid_5;
    public Transform grid_6;
    public Transform grid_7;
    public Transform grid_8;
    public Transform grid_9;
    public Transform grid_10;
    public Transform grid_11;
    public Transform grid_12;
    public Transform grid_13;
    public Transform grid_14;
    public Transform grid_15;
    public Transform grid_16;
    public Gridder grids1;
    public Gridder grids2;
    public Gridder grids3;
    public Gridder grids4;
    public Gridder grids5;
    public Gridder grids6;
    public Gridder grids7;
    public Gridder grids8;
    public Gridder grids9;
    public Gridder grids10;
    public Gridder grids11;
    public Gridder grids12;
    public Gridder grids13;
    public Gridder grids14;
    public Gridder grids15;
    public Gridder grids16;
    public Shop_Icons SIO;
    public MeshRenderer MR_Info;

    public bool Hi;
    public bool Me;
    public bool lo;
    public bool Show;
    public Vector3 Original_Position;
    public bool Operation_Done;

    public Ipad_Grab I_G;
    public Timer TIMER;

    // Start is called before the first frame update
    void Start()
    {
        Show = false;
        Activated = true;
        self_position = GetComponent<Transform>();
        Right_Hand_Position = GameObject.FindGameObjectWithTag("Right").transform;
        Left_Hand_Position = GameObject.FindGameObjectWithTag("Left").transform;
        MR_self = GetComponent<MeshRenderer>();
        Original_Position = self_position.position;
        Operation_Done = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Hi == true)
        {
            if (SIO.Release_Hi == ID)
            {
                Show = true;
            }
        }
        if (Me == true)
        {
            if (SIO.Release_Me == ID)
            {
                Show = true;
            }
        }
        if (lo == true)
        {
            if (SIO.Release_Lo == ID)
            {
                Show = true;
            }
        }
        if (Show == false)
        {
            MR_self.enabled = false;
            MR_Info.enabled = false;
            self_position.position = Original_Position * 10;
        }
        else
        {
            if (Operation_Done == false)
            {
                MR_self.enabled = true;
                MR_Info.enabled = true;
                self_position.position = Original_Position;
                Operation_Done = true;
            }
        }




        if (Activated == false)
        {
            if (Hi == true)
            {
                if (TIMER.payout == true)
                {
                    I_G.money = I_G.money + 100 + Random.Range(0, 50);
                }
            }
            if (Me == true)
            {
                if (TIMER.payout == true)
                {
                    I_G.money = I_G.money + 50 + Random.Range(0, 50);
                }
            }
            if (lo == true)
            {
                if (TIMER.payout == true)
                {
                    I_G.money = I_G.money + 10 + Random.Range(0, 50);
                }
            }
        }





        if (Activated == true)
        {
            Locked_On_Left = false;
            Locked_On_Right = false;
            // CHecks wich hand is closer True for right hand, False for left hand.
            if (Vector3.Distance(self_position.position, Right_Hand_Position.position) < Vector3.Distance(self_position.position, Left_Hand_Position.position))
            {
                Right_Hand_Left_Hand = true;
            }
            else
            {
                Right_Hand_Left_Hand = false;
            }

            Debug.Log(self_position.localScale);
            Debug.Log(Vector3.Distance(self_position.position, Right_Hand_Position.position));
            if (Right_Hand_Left_Hand == true)
            {
                if (self_position.localScale.z > (Vector3.Distance(self_position.position, Right_Hand_Position.position) * 28))
                {
                    Close_Enough = true;
                    if (VAPI.Right_trigger_Down == true)
                    {
                        if (Disabled_Right == false)
                        {
                            if (Activated == true)
                            {
                                self_position.position = Right_Hand_Position.position;
                                self_position.rotation = Right_Hand_Position.rotation;
                                Locked_On_Right = true;
                            }

                            //Move object with controlor until clipped in or released on the right hand
                            //this bit of code controlls grid snapping

                            if (grids1.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_1.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_1.position;
                                        self_position.rotation = grid_1.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }


                            if (grids2.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_2.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_2.position;
                                        self_position.rotation = grid_2.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }


                            if (grids3.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_3.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_3.position;
                                        self_position.rotation = grid_3.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }



                            if (grids4.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_4.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_4.position;
                                        self_position.rotation = grid_4.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids5.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_5.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_5.position;
                                        self_position.rotation = grid_5.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids6.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_6.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_6.position;
                                        self_position.rotation = grid_6.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids7.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_7.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_7.position;
                                        self_position.rotation = grid_7.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids8.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_8.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_8.position;
                                        self_position.rotation = grid_8.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids9.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_9.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_9.position;
                                        self_position.rotation = grid_9.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids10.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_10.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_10.position;
                                        self_position.rotation = grid_10.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }





                            if (grids11.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_11.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_11.position;
                                        self_position.rotation = grid_11.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }




                            if (grids12.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_12.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_12.position;
                                        self_position.rotation = grid_12.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }



                            if (grids13.Close_Enough == false)
                            {
                                if (grids13.Close_Enough == false)
                                    if (Vector3.Distance(Right_Hand_Position.position, grid_13.position) < .12)
                                    {
                                        try
                                        {
                                            self_position.position = grid_13.position;
                                            self_position.rotation = grid_13.rotation;
                                            Activated = false;
                                        }
                                        finally
                                        {

                                        }
                                    }
                            }





                            if (grids14.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_14.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_14.position;
                                        self_position.rotation = grid_14.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }











                            if (grids15.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_15.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_15.position;
                                        self_position.rotation = grid_15.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }








                            if (grids16.Close_Enough == false)
                            {
                                if (Vector3.Distance(Right_Hand_Position.position, grid_16.position) < .12)
                                {
                                    try
                                    {
                                        self_position.position = grid_16.position;
                                        self_position.rotation = grid_16.rotation;
                                        Activated = false;
                                    }
                                    finally
                                    {

                                    }
                                }
                            }








                        }
                    }
                }
                else
                {
                    Close_Enough = false;
                }
            }

            if (Right_Hand_Left_Hand == false)
            {
                if (self_position.localScale.z > (Vector3.Distance(self_position.position, Left_Hand_Position.position) * 28))
                {
                    Close_Enough = true;
                    if (VAPI.Left_Trigger_Down == true)
                    {
                        if (Disabled_Left == false)
                        {
                            if (Activated == true)
                            {
                                //Move object with controlor until clipped in or released on the left hand
                                self_position.transform.position = Left_Hand_Position.position;
                                self_position.rotation = Left_Hand_Position.rotation;
                                Locked_On_Left = true;
                            }


                            if (Vector3.Distance(Left_Hand_Position.position, grid_1.position) < .12)
                            {
                                try
                                {
                                    if (grids1.Close_Enough == false)
                                    {
                                        self_position.position = grid_1.position;
                                        self_position.rotation = grid_1.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_2.position) < .12)
                            {
                                try
                                {
                                    if (grids2.Close_Enough == false)
                                    {
                                        self_position.position = grid_2.position;
                                        self_position.rotation = grid_2.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_3.position) < .12)
                            {
                                try
                                {
                                    if (grids3.Close_Enough == false)
                                    {
                                        self_position.position = grid_3.position;
                                        self_position.rotation = grid_3.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_4.position) < .12)
                            {
                                try
                                {
                                    if (grids4.Close_Enough == false)
                                    {
                                        self_position.position = grid_4.position;
                                        self_position.rotation = grid_4.rotation;
                                        Activated = false;
                                    }
                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_5.position) < .12)
                            {
                                try
                                {
                                    if (grids5.Close_Enough == false)
                                    {
                                        self_position.position = grid_5.position;
                                        self_position.rotation = grid_5.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_6.position) < .12)
                            {
                                try
                                {
                                    if (grids6.Close_Enough == false)
                                    {
                                        self_position.position = grid_6.position;
                                        self_position.rotation = grid_6.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_7.position) < .12)
                            {
                                try
                                {
                                    if (grids7.Close_Enough == false)
                                    {
                                        self_position.position = grid_7.position;
                                        self_position.rotation = grid_7.rotation;
                                        Activated = false;
                                    }
                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_8.position) < .12)
                            {
                                try
                                {
                                    if (grids8.Close_Enough == false)
                                    {
                                        self_position.position = grid_8.position;
                                        self_position.rotation = grid_8.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_9.position) < .12)
                            {
                                try
                                {
                                    if (grids9.Close_Enough == false)
                                    {
                                        self_position.position = grid_9.position;
                                        self_position.rotation = grid_9.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_10.position) < .12)
                            {
                                try
                                {
                                    if (grids10.Close_Enough == false)
                                    {
                                        self_position.position = grid_10.position;
                                        self_position.rotation = grid_10.rotation;
                                        Activated = false;
                                    }
                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_11.position) < .12)
                            {
                                try
                                {
                                    if (grids11.Close_Enough == false)
                                    {
                                        self_position.position = grid_11.position;
                                        self_position.rotation = grid_11.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_12.position) < .12)
                            {
                                try
                                {
                                    if (grids12.Close_Enough == false)
                                    {
                                        self_position.position = grid_12.position;
                                        self_position.rotation = grid_12.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_13.position) < .12)
                            {
                                try
                                {
                                    if (grids13.Close_Enough == false)
                                    {
                                        self_position.position = grid_13.position;
                                        self_position.rotation = grid_13.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_14.position) < .12)
                            {
                                try
                                {
                                    if (grids14.Close_Enough == false)
                                    {
                                        self_position.position = grid_14.position;
                                        self_position.rotation = grid_14.rotation;
                                        Activated = false;
                                    }

                                }
                                finally
                                {

                                }
                            }

                            if (Vector3.Distance(Left_Hand_Position.position, grid_15.position) < .12)
                            {
                                try
                                {
                                    if (grids15.Close_Enough == false)
                                    {
                                        self_position.position = grid_15.position;
                                        self_position.rotation = grid_15.rotation;
                                        Activated = false;
                                    }
                                }
                                finally
                                {

                                }
                            }
                            if (Vector3.Distance(Left_Hand_Position.position, grid_16.position) < .12)
                            {
                                try
                                {
                                    if (grids15.Close_Enough == false)
                                    {
                                        self_position.position = grid_16.position;
                                        self_position.rotation = grid_16.rotation;
                                        Activated = false;
                                    }
                                }
                                finally
                                {

                                }
                            }
                        }
                    }
                }
                else
                {
                    Close_Enough = false;
                }
            }
        }
    
    }
}
