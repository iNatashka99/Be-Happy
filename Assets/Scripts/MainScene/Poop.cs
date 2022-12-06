using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    public Animator AnimPoop;
    public bool pop;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            AnimPoop.SetInteger("poop", 1);
        else
            AnimPoop.SetInteger("poop", 0);

        if (pop)
            AnimPoop.SetInteger("poop", 1);
        else
            AnimPoop.SetInteger("poop", 0);
    }
}
