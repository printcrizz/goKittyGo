using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingButtons : MonoBehaviour
{
    private CatMovement caty;

    public void Start()
    {
        caty = GetComponent<CatMovement>();
       
    }

    public void RightOnPress()
    {
        caty.RActivator(true);
    }

    public void RightOnRelease()
    {
        caty.RActivator(false);
    }
    public void LefttOnPress()
    {
        caty.LActivator(true);
    }

    public void LeftOnRelease()
    {
        caty.LActivator(false);
    }


}
