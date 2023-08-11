using System;
using System.Drawing;
using System.Reflection;

public class CustomList<TItem> 
{
    public TItem[] _items;
    private int _size ;
    public CustomList()
    {
        _items = new TItem[2];
        _size = 0;
    }

    public CustomList(int Capacity)
    {
        _items = new TItem[Capacity];
        _size = 0;
    }

    public void Add(TItem item)
    {       
        if(_size == _items.Length ) 
        {
            TItem[] _newItems = new TItem[2 * _size];
            Array.Copy(_items, _newItems, _items.Length);
            _items = _newItems;
        }
        _items[_size++] = item;
    }
    public void AddRange(TItem[] items)
    {
        foreach( TItem item in items )
            Add(item);
    }
    public bool Contains(TItem item)
    {
        foreach(var element in _items)
        {
            if(item.Equals(element))
                return true;
        }
        return false;
    }
    public void CopyTo(in TItem[] array)
    { 
       Array.Copy(_items,array, _items.Length);
    }
    public int Indexof(TItem item)
    {
       for(var index = 0; index < _items.Length; index++)
        {
            if (_items[index].Equals(item))
                return index;
        }
       return -1;
    }
    public void Insert(int index, TItem item)
    {
        try
        {
            var newArray = new TItem[_items.Length];
            for (var indexA = 0; indexA < index; indexA++)
            {
                newArray[indexA] = _items[indexA];
            }
            newArray[index] = item;
            for (var indexA = index + 1; indexA < _items.Length ; indexA++)
            {
                 newArray[indexA] = _items[indexA - 1] ;
            }
            _items = newArray;
        }
        catch (Exception ex)
        {
            throw new Exception("index topilmadi");
        }
    }
    public void InsertRange(int index, TItem[] items)
    {
        foreach(var item in items)
        {
            Insert(index, item);
            index++;
        }
    }
    public bool Remove(TItem item) 
    {
        foreach (var ind in _items)
        {
            if (item.Equals(ind))
            {
                var findIndex = Indexof(item);
                var newArray = new TItem[_items.Length];
                for (var indexA = 0; indexA < findIndex ; indexA++)
                {
                    newArray[indexA] = _items[indexA];
                }
                for (var indexA = findIndex + 1; indexA < _items.Length; indexA++)
                {
                    newArray[indexA] = _items[indexA];
                }
                _items = newArray;return true;
            }
        }
        return false;
    }
    public bool RemoveAt(int index)
    {
        for(var ind = 0;ind < _items.Length;ind++)
        {
            if (ind == index)
            {
                var newArray = new TItem[_items.Length];
                for (var indexA = 0; indexA < index; indexA++)
                {
                    newArray[indexA] = _items[indexA];
                }
                for (var indexA = index + 1; indexA < _items.Length; indexA++)
                {
                    newArray[indexA] = _items[indexA];
                }
                _items = newArray;
                return true;
            }
        }
        return false;
    }
    public Array ToArray()
    {
       return  _items.ToArray();
       
    }
}

