using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goopnic_animation : MonoBehaviour
{
    Vector3 v, q1, q2;
    private void Start()
    {
        v = new Vector3(0, 0, 1f);
        q1 = new Vector3(0f, 0f, 10f);
        q2 = new Vector3(0f, 0f, 350f);
    }

    void Update()
    {
        if ((transform.rotation.eulerAngles.z <= q2.z + 1) & (transform.rotation.eulerAngles.z >= q1.z - 1))
        {
            v = -v;
        }
        transform.Rotate(70 * v * Time.deltaTime);
    }
}

