using UnityAtoms.BaseAtoms;
using UnityEngine;

public class GameObjectEntitySystem : MonoBehaviour
{


    [SerializeField] GameObjectDatabase database;

    void Awake()
    {
        database.Start();
    }


}