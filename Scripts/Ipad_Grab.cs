using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ipad_Grab : MonoBehaviour
{
    public bool Right_Is_Closer;
    public Transform Ipad_Trans;
    public Transform Right_Trans;
    public Transform Left_Trans;
    public VR_API VAPI;
    public bool UseAutoTransform;
    public bool In_Shop;
    public TextMesh TX;
    public TextMesh TX_EXAMPLE;
    public TextMesh TX_SHOP_EXAMPLE;
    public MeshRenderer LowIN;
    public MeshRenderer HiIN;
    public MeshRenderer MidIn;
    public bool Grabbed;
    public int money;
    public Timer TIME;
    // Start is called before the first frame update
    void Start()
    {
        if (UseAutoTransform == true)
        {
            Ipad_Trans = GetComponent<Transform>();
        }
        LowIN.enabled = false;
        MidIn.enabled = false;
        HiIN.enabled = false;
        money = 2000;
    }

    // Update is called once per frame
    void Update()
    {
        if (In_Shop == true)
        {
            TX.text = TX_SHOP_EXAMPLE.text + "Money: " + money;
        }
        else
        {
            TX.text = TX_EXAMPLE.text + "Money: " + money;
            TX.text = TX_EXAMPLE.text + "Days: " + TIME.Day;
        }
        Grabbed = false;
        Right_Is_Closer = true;
        if (Vector3.Distance(Right_Trans.position, Ipad_Trans.position) > Vector3.Distance(Left_Trans.position, Ipad_Trans.position))
        {
            Right_Is_Closer = false;
        }
        if (Right_Is_Closer == true)
        {
            if (VAPI.Right_trigger_Down == true)
            {
                if (Vector3.Distance(Ipad_Trans.position, Right_Trans.position) < .1)
                {
                    Ipad_Trans.position = Right_Trans.position;
                    Ipad_Trans.rotation = Right_Trans.rotation;
                    Grabbed = true;
                    if (In_Shop == false)
                    {
                        if (VAPI.A_Button_Down == true)
                        {
                            In_Shop = true;
                            LowIN.enabled = true;
                            MidIn.enabled = true;
                            HiIN.enabled = true;
                            TX.text = TX_SHOP_EXAMPLE.text + "Money: " + money;
                        }
                    }
                    else 
                    {
                        if (VAPI.B_Button_Down == true)
                        {
                            In_Shop = false;
                            TX.text = TX_EXAMPLE.text;
                            LowIN.enabled = false;
                            MidIn.enabled = false;
                            HiIN.enabled = false;
                        }
                    }
                }
            }
        }
        else
        {
            if (VAPI.Left_Trigger_Down == true)
            {
                if (Vector3.Distance(Ipad_Trans.position, Left_Trans.position) < .1)
                {
                    Ipad_Trans.position = Left_Trans.position;
                    Ipad_Trans.rotation = Left_Trans.rotation;
                    Grabbed = true;
                    if (In_Shop == false)
                    {
                        if (VAPI.A_Button_Down == true)
                        {
                            In_Shop = true;
                            TX.text = TX_SHOP_EXAMPLE.text;
                            LowIN.enabled = true;
                            MidIn.enabled = true;
                            HiIN.enabled = true;
                            TX.text = TX_SHOP_EXAMPLE.text + "Money: " + money;
                        }
                    }
                    else if (VAPI.B_Button_Down == true)
                    {
                        In_Shop = false;
                        TX.text = TX_EXAMPLE.text;
                        LowIN.enabled = false;
                        MidIn.enabled = false;
                        HiIN.enabled = false;
                    }
                }
            }
        }
        
    }
}
