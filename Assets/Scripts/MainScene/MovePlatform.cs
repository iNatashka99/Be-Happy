using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private Vector2 target;
    private Vector2 st;
    public float distance;
    public float speed;
    private Rigidbody2D rb;
    private bool fl;

    bool flag=true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = rb.position;
        st = rb.position;
        fl = true;
    }

    void Update()
    {

        if (transform.localScale.x > 5)
        {
            flag = false;
        }
        else if (transform.localScale.x < 2)
        {
            flag = true;
        }
        if (flag)
            transform.localScale += new Vector3(1, 0, 0);
        else
            transform.localScale -= new Vector3(1, 0, 0);
    }
}
