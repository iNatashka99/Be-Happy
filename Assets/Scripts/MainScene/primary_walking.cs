using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primary_walking : MonoBehaviour
{
    private Vector3 target;
    private Vector3 st;
    public float distance;
    public float speed;
    private void Start()
    {
        target = transform.position;
        st = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target & target.x == st.x)
            target.x = st.x + distance;
        else if (transform.position == target & target.x != st.x)
            target.x = st.x;
    }
}
