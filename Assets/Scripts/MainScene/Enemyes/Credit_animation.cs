using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit_animation : MonoBehaviour
{
    Vector3 v, q1,q2;
    private bool fl;
    private void Start()
    {
        fl = true;
        v = new Vector3(0, 0, 1f);
        q1 = new Vector3(0f, 0f, 90f);
        q2 = new Vector3(0f, 0f, 270f);
    }
    
    void Update()
    {
        if ((transform.rotation.eulerAngles.z <= q2.z) & (transform.rotation.eulerAngles.z >= q1.z) &fl)
        {
            v = -v;
            fl = false;
        }
        if ((transform.rotation.eulerAngles.z <=330) & (transform.rotation.eulerAngles.z >= 30) & !fl)
        {
            fl = true;
        }
        transform.Rotate(70 * v * Time.deltaTime);
    }
}
