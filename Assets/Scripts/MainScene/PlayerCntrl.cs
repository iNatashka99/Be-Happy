using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCntrl : MonoBehaviour
{
    public float speed;
    public float jump;
    public bool moveright, moveleft, moveup;
    private Vector2 force;
    private Rigidbody2D rb;
    private bool faceRight = false;
    private bool inAir=false;
    private Finish fin;
    public Animator Anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       fin = FindObjectOfType<Finish>();
        transform.position = new Vector3(0, 0, 0);
        if (PlayerPrefs.GetString("music") == "yes")
            GameObject.Find("nado_radovatsa").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetString("finish", "no");
    }

    // Update is called once per frame
    void Update()
    {
        force = new Vector2(0, jump);

        if (rb.velocity.x == 0 && rb.velocity.y == 0)
        {
            Anim.SetInteger("stand", 1);
            Anim.SetInteger("walk", 0);
            Anim.SetInteger("jump", 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveL();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveR();

        }
        if (Input.GetKey(KeyCode.W))
        {
            MoveU();
        }
        if (moveright)
        {
            MoveR();
        }
        if (moveleft)
        {
            MoveL();
        }
        if (moveup)
        {
            MoveU();
        }

        if (rb.velocity.x > 0 && !faceRight)
            flip();
        else if (rb.velocity.x < 0 && faceRight)
            flip();

    }

    void MoveR()
    {
        if (!inAir)
        {
            Anim.SetInteger("walk", 1);
            Anim.SetInteger("jump", 0);
        }
        Anim.SetInteger("stand", 0);
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void MoveL()
    {
        if (!inAir)
        {
            Anim.SetInteger("walk", 1);
            Anim.SetInteger("jump", 0);
        }
        Anim.SetInteger("stand", 0);
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }

    void MoveU()
    {
        if (!inAir)
        {
            inAir = true;
            Anim.SetInteger("jump", 1);
            Anim.SetInteger("walk", 0);
            Anim.SetInteger("stand", 0);
            rb.AddForce(force);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            inAir = false;
        if (collision.gameObject.tag == "Finish")
        {
            fin.isFinished = true;
        }

    }


    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
