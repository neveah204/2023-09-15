using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainer<T>        //제네릭 형식 Class 사용하기 위해 선언
{
    private T[] items;
    private int currentindex = 0;

    public GenericContainer(int capacity)
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if(currentindex < items.Length)
        {
            items[currentindex] = item;
            currentindex++;
        }
    }

    public T[] Getitems()
    {
        return items;
    }
}
