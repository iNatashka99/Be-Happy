using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private PlayerCntrl player;
    private Poop[] p;

    void Start()
    {
        player = FindObjectOfType<PlayerCntrl>();
        p = new Poop[3];
        p = FindObjectsOfType<Poop>();

    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }
    public void UpArrow()
    {
        player.moveup = true;
    }

    public void Poop()
    {
        p[0].pop = true;
        p[1].pop = true;
        p[2].pop = true;

    }

    public void ReleasePoop()
    {
        p[0].pop = false;
        p[1].pop = false;
        p[2].pop = false;
    }

    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;

    }
    public void ReleaseUpArrow()
    {
        player.moveup = false;
    }

}
