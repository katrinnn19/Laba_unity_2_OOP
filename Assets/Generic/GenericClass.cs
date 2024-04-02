using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<int> myClass = new GenericClass<int>();

        myClass.UpdateItem(5);
    }
}
