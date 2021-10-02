
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityAtoms.Tags;
using System.Linq;

[CreateAssetMenu(fileName = "UseWeaponPivot", menuName = "Zombie Runner/UseWeaponPivot", order = 0)]
public class UseWeaponPivot : ScriptableObject
{

    [SerializeField] GameObjectDatabase gameObjectDatabase;
    [SerializeField] StringConstant weaponPivotTag;

    public Transform GetPivot(IEntity entity)
    {
        return GetPivot(entity.Id);
    }
    public Transform GetPivot(string entity)
    {
        var gameObject = gameObjectDatabase.Get(entity);
        if (gameObject != null)
        {
            var pivot = gameObject.Value.GetComponentsInChildren<AtomTags>().Select((t) => t.gameObject).DefaultIfEmpty(gameObject.Value).First((t) => t.HasTag(weaponPivotTag.Value));
            return pivot.transform;
        }
        return default(Transform);
    }
    public bool TryGetPivot(string entity, out Transform pivot)
    {
        pivot = default(Transform);
        var gameObject = gameObjectDatabase.Get(entity);
        if (gameObject == null)
        {
            return false;
        }
        pivot = gameObject.Value.GetComponentsInChildren<AtomTags>().Select((t) => t.gameObject).DefaultIfEmpty(gameObject.Value).First((t) => t.HasTag(weaponPivotTag.Value)).transform;
        return true;
    }
}