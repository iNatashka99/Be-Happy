using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform1 : MonoBehaviour
{
    private Vector2 target;
    private Vector2 st;
    public float distance;
    public float speed;
    private Rigidbody2D rb;
    private bool fl;

    bool flag = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = rb.position;
        st = rb.position;
        fl = true;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        coll.transform.parent = transform;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        coll.transform.parent = null;
    }

    void Update()
    {
        if (fl)
            rb.MovePosition(rb.position + Vector2.right * 1 * speed * Time.deltaTime);
        else
            rb.MovePosition(rb.position + Vector2.right * -1 * speed * Time.deltaTime);

        if (rb.position.x <= target.x & target.x == st.x)
        {
            target.x = st.x + distance;
            fl = true;
        }
        else if (rb.position.x >= target.x & target.x != st.x)
        {
            target.x = st.x;
            fl = false;
        }
    }
}
