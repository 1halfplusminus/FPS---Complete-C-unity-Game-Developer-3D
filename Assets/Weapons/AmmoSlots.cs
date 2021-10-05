using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;


public interface IAmmoSlots
{

    public IntReactiveProperty this[AmmoType key]
    {
        get;
    }

    void Add(AmmoSlot slot);

}
public interface IOnGameOver
{
    void OnGameOver();
}
[CreateAssetMenu(fileName = "AmmoSlots", menuName = "Zombie Runner/AmmoSlots", order = 0)]
public class AmmoSlots : ScriptableObject, IAmmoSlots, IOnGameOver
{
    [Serializable]
    private struct ReactiveAmmoSlot
    {
        public AmmoType ammoType;
        public IntReactiveProperty amount;
    }



    ReactiveCollection<ReactiveAmmoSlot> collection;

    [SerializeField] List<ReactiveAmmoSlot> slots;

    public IntReactiveProperty this[AmmoType key]
    {
        get => slots.Find((v) => v.ammoType == key).amount;
    }

    void OnEnable()
    {

        collection = slots.ToReactiveCollection();
        collection.ObserveAdd().Subscribe((x) =>
        {
            Debug.Log("Added");
        });
        collection.ObserveCountChanged()
        .Subscribe((x) => slots = collection.ToList());
    }
    void OnDisable()
    {
        Reset();
    }
    public void Reset()
    {
        foreach (var slot in collection)
        {
            slot.amount.Value = 0;
        }
    }
    public void Add(AmmoSlot slot)
    {
        var slotToIncrease = this[slot.ammoType];
        slotToIncrease.Value += slot.amount;
    }

    public void OnGameOver()
    {
        Debug.Log("Reset on game over");
        Reset();
    }
}