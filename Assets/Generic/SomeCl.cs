using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass myClass = new SomeClass();
        myClass.GenericMethod<int>(5);
    }
}
