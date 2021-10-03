using System;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityAtoms;


[CreateAssetMenu(fileName = "Armories", menuName = "Zombie Runner/Armories", order = 0)]
public class Armories : ScriptableObject
{
    [Serializable]
    struct Weapon
    {
        public GameObject Mesh;
        public WeaponVariable Entity;

    }
    [SerializeField] List<Weapon> meshes;

    Dictionary<string, GameObjectVariable> collection;
    private void OnEnable()
    {
        collection = new Dictionary<string, GameObjectVariable>();
        Debug.Log("Armories constructor");
        foreach (var item in meshes)
        {
            var variable = ScriptableObject.CreateInstance<GameObjectVariable>();
            variable.SetValue(item.Mesh.gameObject);
            collection[item.Entity.Value.Id] = variable;
        }
    }

    public GameObject Get(IEntity entity)
    {
        return collection[entity.Id].Value;
    }
}
