using System;
using UnityEngine;

interface IAmmoSlot
{
    public AmmoType ammoType { get; }
    int amount { get; }
}

[Serializable]
public struct AmmoSlot : IAmmoSlot
{

    [SerializeField]
    private AmmoType _ammoType;


    public AmmoType ammoType { get => _ammoType; }

    [SerializeField]
    private int _amount;
    public int amount { get => _amount; }

    public AmmoSlot(AmmoType type, int amount)
    {
        _amount = amount;
        _ammoType = type;
    }
}