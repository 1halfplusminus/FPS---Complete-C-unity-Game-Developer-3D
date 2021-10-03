using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
using System.Linq;

[CreateAssetMenu(fileName = "WeaponQueue", menuName = "Zombie Runner/WeaponQueue", order = 0)]
public class WeaponQueue : ScriptableObject
{

    [SerializeField] AtomList ownedWeapons;
    [SerializeField]
    Queue<Weapon> weaponQueue = new Queue<Weapon>();
    void PopulateQueueIfNeeded()
    {
        weaponQueue = new Queue<Weapon>();
        foreach (var item in ownedWeapons.Value)
        {
            if (item is WeaponVariable weapon)
            {
                weaponQueue.Enqueue(weapon.Value);
            }
        }
    }
    void Awake()
    {
        PopulateQueueIfNeeded();
    }
    void OnEnable()
    {
        PopulateQueueIfNeeded();
        ownedWeapons.Added
        .Observe()
        .Subscribe((v) =>
        {
            if (v is WeaponVariable weapon)
            {
                weaponQueue.Enqueue(weapon.Value);
            }
        });
        ownedWeapons.Removed
       .Observe()
       .Subscribe((v) =>
       {
           if (v is WeaponVariable weapon)
           {
               weaponQueue = new Queue<Weapon>(weaponQueue.Where(x => x.Id == weapon.Value.Id));
           }
       });
    }

    public Weapon Next()
    {
        return weaponQueue.Dequeue();
    }
    public bool TryNext(out Weapon weapon)
    {
        if (weaponQueue.Count == 0)
        {
            weapon = default(Weapon);
            return false;
        }
        weapon = weaponQueue.Dequeue();
        return true;
    }
    public void UnEquip(Weapon weapon)
    {
        weaponQueue.Enqueue(weapon);
    }
}