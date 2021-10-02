using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

[CreateAssetMenu(fileName = "UseEntity", menuName = "Zombie Runner/UseEntity", order = 0)]
public class UseEntity : ScriptableObject
{

    [SerializeField] GameObjectDatabase database;

    public GameObjectVariable Get(string id)
    {
        return database.Get(id);
    }

    public static implicit operator MonoBehaviour(UseEntity useEntity)
    {
        return new MonoBehaviour();
    }

}