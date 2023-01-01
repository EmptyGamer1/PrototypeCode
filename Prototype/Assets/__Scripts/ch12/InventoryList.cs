using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryList<T>
{
    private T _item;

    public T Item { get => _item; }

    public InventoryList()
    {
        Debug.Log("InventoryList initialized...");
    }

    public void GenericMethod<K>(K genericParameter)
    {
        Debug.Log(genericParameter);
    }

    public void SetItem(T newItem)
    {
        _item = newItem;
        Debug.Log("New item added...");
    }
}
