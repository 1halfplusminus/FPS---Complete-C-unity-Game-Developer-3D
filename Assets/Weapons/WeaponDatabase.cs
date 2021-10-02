using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;


[CreateAssetMenu(fileName = "DamagesDatabase", menuName = "Zombie Runner/DamagesDatabase", order = 0)]
public class WeaponDatabase : ScriptableObject
{
    [SerializeField] Armories armories;

    [SerializeField] AtomCollectionReference weapons;

    [SerializeField] AtomCollectionReference equipedWeapon;

    [SerializeField] EntityEvent onEntityRemoved;

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
        weapons.Collection.Value.TryGetValue(new StringReference(weaponId), out variable);
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
        var equiped = equipedWeapon.Collection.Value.Get<WeaponVariable>(id);
        if (!equiped)
        {
            WeaponVariable baseWeapon = ScriptableObject.CreateInstance<WeaponVariable>();
            equipedWeapon.Collection.GetValue().Add(id, baseWeapon);
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
        equipedWeapon.Collection.GetValue().Add(entity.Id, weapon);
        return true;
    }
    public GameObject GetWeaponPrefabs(Weapon weapon)
    {
        return armories.Get(weapon);
    }
    private void OnEnable()
    {
        equipedWeapon.Collection.Value.Clear();
        onEntityRemoved.Register(ClearEntity);
        Debug.Log("Enable weapon database");
    }
    private void ClearEntity(Entity entity)
    {
        Debug.Log("Remove entity: " + entity.Id + " from weapon database");
        equipedWeapon.Collection.GetValue().Remove(entity.Id);
    }
    private void OnDisable()
    {
        equipedWeapon.Collection.Value.Clear();
        Debug.Log("Disable weapon database");
    }
}
