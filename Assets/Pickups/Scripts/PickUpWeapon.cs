using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;

public class PickUpWeapon : MonoBehaviour
{
    [SerializeField] WeaponEventReference onWeaponPickup;

    // TODO: Replace with a class that hide the collection
    [SerializeField] AtomList ownedWeapon;

    void Start()
    {
        onWeaponPickup.Event.Observe().TakeUntilDisable(this).Subscribe((e) =>
        {
            // TODO: Replace with a class that hide the collection
            var variable = ScriptableObject.CreateInstance<WeaponVariable>();
            variable.Value = e;
            ownedWeapon.Value.Add(variable);
        });
    }
}