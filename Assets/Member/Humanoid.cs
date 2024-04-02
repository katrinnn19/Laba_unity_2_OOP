using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid
{
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }


}
public class Ennemy : Humanoid
{
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
public class Orc : Ennemy
{

    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}

