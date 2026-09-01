using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : Identity
{
    public GameObject youwin;

    public override void Hit()
    {
        youwin.SetActive(true);
    }

}
