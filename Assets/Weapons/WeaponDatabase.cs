using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "DamagesDatabase", menuName = "Zombie Runner/DamagesDatabase", order = 0)]
public class WeaponDatabase : ScriptableObject
{
    [SerializeField] Armories armories;

    [SerializeField] AtomCollection weapons;

    [SerializeField] AtomCollection equipedWeapon;

    [SerializeField] EntityEvent onEntityRemoved;

    [SerializeField] List<WeaponVariable> defaultWeapon;
    void Awake()
    {
        Debug.Log("Enable weapon database");
        OnEnable();
    }
    public bool TryGetDommage(string weaponId, out int damage)
    {
        WeaponVariable weapon;
        var result = TryGetWeapon(weaponId, out weapon);
        damage = weapon.Value.damage;
        return result;
    }
    public bool TryGetWeapon(string weaponId, out WeaponVariable weapon)
    {
        AtomBaseVariable variable;
        weapons.Value.TryGetValue(new StringReference(weaponId), out variable);
        if (variable is WeaponVariable)
        {
            weapon = variable as WeaponVariable;
            return true;
        }
        weapon = default;
        return false;
    }
    public WeaponVariable GetEquipedWeapon(string id)
    {
        var equiped = equipedWeapon.Value.Get<WeaponVariable>(id);
        if (!equiped)
        {
            WeaponVariable baseWeapon = ScriptableObject.CreateInstance<WeaponVariable>();
            equipedWeapon.GetValue().Add(id, baseWeapon);
            return baseWeapon;
        }
        return equiped;
    }
    public bool EquipWeapon(IEntity entity, string weaponId)
    {
        WeaponVariable weapon = GetEquipedWeapon(entity.Id);
        WeaponVariable baseWeapon;
        var findWeapon = TryGetWeapon(weaponId, out baseWeapon);
        weapon.SetValue(baseWeapon.Value);
        return findWeapon;
    }
    public bool EquipWeapon(IEntity entity, WeaponVariable weapon)
    {
        equipedWeapon.GetValue().Add(entity.Id, weapon);
        return true;
    }
    public GameObject GetWeaponPrefabs(Weapon weapon)
    {
        return armories.Get(weapon);
    }
    private void OnEnable()
    {
        equipedWeapon.Value.Clear();
        onEntityRemoved.Register(ClearEntity);
        Debug.Log("Enable weapon database");
        foreach (var item in defaultWeapon)
        {
            Debug.Log("Add weapon " + item.Id + " to database");
            weapons.GetValue().Add(item.Value.Id, item);
        }
    }
    private void ClearEntity(Entity entity)
    {
        Debug.Log("Remove entity: " + entity.Id + " from weapon database");
        equipedWeapon.GetValue().Remove(entity.Id);
    }
    private void OnDisable()
    {
        equipedWeapon.Value.Clear();
        Debug.Log("Disable weapon database");
    }
}
