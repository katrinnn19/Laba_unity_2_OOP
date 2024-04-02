using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public string color;
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
public class Apple : Fruit
{
    public Apple()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public Apple(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
