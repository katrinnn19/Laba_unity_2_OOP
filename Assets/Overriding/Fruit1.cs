using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit1 
{
    public Fruit1()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    //These methods are virtual and thus can be overriden
    //in child classes
    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
public class Apple1 : Fruit1
{
    public Apple1()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //These methods are overrides and therefore
    //can override any virtual methods in the parent
    //class.
    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}