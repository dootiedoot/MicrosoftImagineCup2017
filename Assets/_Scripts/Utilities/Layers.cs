﻿using UnityEngine;
using System.Collections;

public class Layers
{
    // A list of tag strings.
    //public static LayerMask Players = 1 << 9;
    //public static LayerMask Platform = 1 << 11;
    public const int Players = 9;
    public const int Platforms = 11;
    public const int ViewAlways = 13;   
    public static LayerMask PushPullable = 1 << 8;


    //  Global function to changelayers 
    public static void ChangeLayers(GameObject go, int layer)
    {
        go.layer = layer;
        foreach (Transform child in go.transform)
            ChangeLayers(child.gameObject, layer);
    }
}
