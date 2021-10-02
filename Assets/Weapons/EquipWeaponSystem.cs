using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using System.Linq;
public class EquipWeaponSystem : MonoBehaviour
{

    [SerializeField] WeaponDatabase weaponDatabase;

    [SerializeField] WeaponEntityEventReference onChangeWeapon;
    [SerializeField] GameObjectTransformEventReference onInstanciate;

    [SerializeField] UseWeaponPivot useWeaponPivot;

    void OnDestroy()
    {
        onChangeWeapon.Event.Unregister(ChangeWeapon);
    }

    void Awake()
    {

        onChangeWeapon.Event.Register(ChangeWeapon);
    }

    void ChangeWeapon(WeaponEntity weaponEntity)
    {
        weaponDatabase.EquipWeapon(weaponEntity.entity, weaponEntity.weapon.Id);
        var weaponPrefabs = weaponDatabase.GetWeaponPrefabs(weaponEntity.weapon);
        if (weaponPrefabs)
        {
            Transform pivot;
            var havePivot = useWeaponPivot.TryGetPivot(weaponEntity.entity.Id, out pivot);
            if (havePivot)
            {
                Debug.Log(weaponEntity.entity + " equipped " + weaponEntity.weapon.name);
                onInstanciate.Event.Raise(new GameObjectTransform() { gameObject = weaponPrefabs, transform = pivot });
            }

        }

    }

}