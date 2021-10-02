using System;
using UnityEngine;

[Serializable]
public struct Shoot
{
    public string shooter;
    public Vector3 position;
    public Vector3 direction;

    public float range;

    public Shoot(string shooter, Vector3 position, Vector3 direction, float range)
    {
        this.shooter = shooter;
        this.position = position;
        this.direction = direction;
        this.range = range;
    }
}