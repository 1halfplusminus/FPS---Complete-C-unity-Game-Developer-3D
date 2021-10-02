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
[CreateAssetMenu(fileName = "AmmoSlots", menuName = "Zombie Runner/AmmoSlots", order = 0)]
public class AmmoSlots : ScriptableObject, IAmmoSlots
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

    public void Add(AmmoSlot slot)
    {
        var slotToIncrease = this[slot.ammoType];
        slotToIncrease.Value += slot.amount;
    }
}