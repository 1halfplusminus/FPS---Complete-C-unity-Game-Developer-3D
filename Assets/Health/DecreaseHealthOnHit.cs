using UnityEngine;
using UnityAtoms.BaseAtoms;
public class DecreaseHealthOnHit : MonoBehaviour
{
    [SerializeField] HitEventReference onHit;

    [SerializeField] AtomCollectionReference healths;

    [SerializeField] WeaponDatabase weapons;
    void Awake()
    {
        onHit.Event.Register(DeacreaseHealth);
    }
    void OnDestroy()
    {
        onHit.Event.Unregister(DeacreaseHealth);
    }
    private void OnDisable()
    {

    }
    void DeacreaseHealth(Hit hit)
    {
        IntVariable targetHealth = healths.Collection.Value.Get<IntVariable>(hit.hitted);
        if (!targetHealth)
        {
            Debug.Log(hit.hitted + "  have no health ");
        }
        else
        {
            var weapon = weapons.GetEquipedWeapon(hit.shoot.shooter);
            Debug.Log(hit.shoot.shooter + " has hit " + hit.hitted + " with :" + weapon.name + " for " + weapon.Value.damage);
            targetHealth.Value -= weapon.Value.damage;
        }
    }
}