using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Icon_Small : MonoBehaviour
{
    public Transform self_trans;
    public Transform Right_Hand;
    public Transform Left_Hand;
    public bool close_Enough;

    public MeshRenderer self_MR;
    public Material Standard;
    public Material Glowing;
    public VR_API VAPI;
    public MeshRenderer Text_MR;
    // Start is called before the first frame update
    void Start()
    {
        self_trans = GetComponent<Transform>();
        self_MR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Text_MR.enabled = false;
        close_Enough = false;
        self_trans.Rotate(0, 1, 0);
        Debug.Log(Vector3.Distance(self_trans.localScale, Right_Hand.position)+ "Hand position");
        if (Vector3.Distance(Right_Hand.position, self_trans.position) < .12)
        {
            close_Enough = true;
            self_MR.material = Glowing;
            if (VAPI.A_Button_Down == true)
            {
                Text_MR.enabled = true;
            }
        }
        else
        {
            self_MR.material = Standard;
        }
    }
}
