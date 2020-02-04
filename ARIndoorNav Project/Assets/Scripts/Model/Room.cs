﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Room
{
    private string name;
    private string description;
    private Transform location;
    private Image image;
    private string distanceToUser;
    private int floor = -1;

    private Room() { }

    //TODO Room tags?
    public Room(string name, Transform location, string description)
    {
        Name = name;
        Location = location;
        Description = description;

        foreach (var ch in name.ToCharArray())
        {
            if(char.IsNumber(ch))
            {
                floor = (int) char.GetNumericValue(ch);
                return;
            }
        }
    }

    /*
        Contains method that only checks the Name (Number) of the room
        It is used to check against OCR results
    */
    public bool Contains(string text)
    {
        var contains = false;
        if(Name.Contains(text))
            contains = true;

        return contains;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }

    }

    public Transform Location
    {
        get { return location; }
        set { location = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public Image Image
    {
        get { return image; }
        set { image = value; }
    }

    public string DistanceToUser
    {
        get { return distanceToUser; }
        set { distanceToUser = value; }
    }

    public int Floor
    {
        get { return floor; }
        set { floor = value; }
    }

}