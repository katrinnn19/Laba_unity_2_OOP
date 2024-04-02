using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad1 : MonoBehaviour
{
    void Start()
    {
        Apple1 myApple = new Apple1();

        myApple.SayHello();
        myApple.Chop();
        Fruit1 myFruit = new Apple1();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
