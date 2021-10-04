using System;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityAtoms;


[CreateAssetMenu(fileName = "Armories", menuName = "Zombie Runner/Armories", order = 0)]
public class Armories : ScriptableObject
{
    [Serializable]
    struct WeaponMesh
    {
        [SerializeReference]
        public GameObject Mesh;
        [SerializeField]
        public WeaponVariable Entity;

    }
    [SerializeField] List<WeaponMesh> meshes;


    Dictionary<string, GameObjectVariable> collection;

    void Awake()
    {
        OnEnable();
    }
    void OnEnable()
    {
        collection = new Dictionary<string, GameObjectVariable>();
        Debug.Log("Armories constructor");
        foreach (var item in meshes)
        {
            var variable = ScriptableObject.CreateInstance<GameObjectVariable>();
            if (item.Mesh != null)
            {
                variable.SetValue(item.Mesh.gameObject);
            }
            collection[item.Entity.Value.Id] = variable;
        }
    }

    public GameObject Get(IEntity entity)
    {
        if (collection.ContainsKey(entity.Id))
        {
            return collection[entity.Id].Value;
        }
        return null;
    }
}
