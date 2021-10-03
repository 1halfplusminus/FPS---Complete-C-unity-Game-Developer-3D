using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;



[Serializable]
public struct Weapon : IEntity, IEquatable<IEntity>
{
    public string Id;
    public string name;
    public int damage;

    [Range(0f, 30f)]

    public float zoom;

    [Range(0f, 600f)]
    public float range;

    [Range(0, 3000)]
    public long throttle;

    [Range(0, 10000)]
    public long reloadTime;
    public String hitEffect;

    public String shootEffect;
    [SerializeField]
    public AmmoType AmmoType;
    /* [SerializeField]
    StringConstant _hitEffect;

    [SerializeField]
    StringConstant _shootEffect; */

    string IEntity.Id => Id;

    public bool Equals(IEntity other)
    {
        return other.Id == Id;
    }

}