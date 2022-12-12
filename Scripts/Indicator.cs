using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    public MeshRenderer selfMR;
    public Material Wrong;
    public Material Right;
    // Start is called before the first frame update
    void Start()
    {
        selfMR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 10) == 5)
        {
            selfMR.material = Right;
        }
        else
        {
            selfMR.material = Wrong;
        }
    }
}
