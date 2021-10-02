using System;
using UnityEngine;

[Serializable]
public struct Hit
{
    public Shoot shoot;
    public string hitted;
    public Vector3 position;

    public Hit(Shoot shoot, string hitted, Vector3 position)
    {
        this.shoot = shoot;
        this.hitted = hitted;
        this.position = position;
    }
}