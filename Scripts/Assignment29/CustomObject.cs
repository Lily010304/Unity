using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29
{
public class CustomObject 
{
    int _id;
    string _name;

    public int ID
    {
        get { return _id;}
        set { _id = value;}
    }

    public string Name
    {
        get {return _name;}
        set {_name = value;}
    }

    public CustomObject (int id, string name)
    {
        this._id = id;
        this._name = name;
    }

    public override string ToString()
    {
        return $"Object [ID: {ID}, Name: {Name}]";
    }

    // public override bool Equals(object obj)
    // {
    //     if (obj != null)
    //     { 
    //         CustomObject custom = obj as CustomObject;
    //         return this.ID == custom?.ID && this.Name == custom?.Name;
    //     }
    //     return false;
    // }

    public static bool operator ==(CustomObject obj1, CustomObject obj2)
    {
        if (obj1?.ID != obj2?.ID || obj1?.Name != obj2?.Name)
        {
            return false;
        }
        return true;
    }

    public static bool operator !=(CustomObject obj1, CustomObject obj2)
    {
        if (obj1?.ID == obj2?.ID && obj1?.Name == obj2?.Name)
        {
            return false;
        }
        return true;
    }


}
}
