using UnityEngine;
using UnityAtoms.BaseAtoms;
using UniRx;
using UniRx.Triggers;

[CreateAssetMenu(fileName = "GameObjectDatabase", menuName = "Zombie Runner/GameObjectDatabase", order = 0)]
public class GameObjectDatabase : ScriptableObject
{

    [SerializeField] GameObjectVariable baseGameObject;
    [SerializeField] GameObjectEntityEvent onAttachEntityToGameObject;
    [SerializeField] VoidEvent onInit;
    [SerializeField] AtomCollectionReference collection;
    [SerializeField] EntityEventReference entityRemoved;

    public void Start()
    {
        Debug.Log("Start From GameObjectDatabase");
        onInit.Raise();
    }
    void OnEnable()
    {
        Debug.Log("Enable GameObjectDatabase");
        onAttachEntityToGameObject.Register(Attach);

    }
    void OnDisable()
    {
        Reset();
        Debug.Log("Disable GameObjectDatabase");
    }
    public void Add(Entity entity, GameObjectVariable gameObject)
    {
        collection.Collection.Value.Add(entity.Id, gameObject);
        gameObject.Value.OnDestroyAsObservable().Subscribe((x) =>
        {
            Debug.Log(entity.Id + " game object destroyed ");
            collection.Collection.Value.Remove(entity.Id);
            entityRemoved.Event.Raise(entity);
        });

    }

    public GameObjectVariable Get(IEntity entity)
    {
        return collection.Collection.Value.Get<GameObjectVariable>(entity.Id);
    }
    public GameObjectVariable Get(string id)
    {
        return collection.Collection.Value.Get<GameObjectVariable>(id);
    }

    public void Reset()
    {
        collection.Collection.Value.Clear();
    }

    void Attach(GameObjectEntity gameObjectEntity)
    {
        Debug.Log("attach:" + gameObjectEntity.entity.Id + " to " + gameObjectEntity.gameObject.name);
        var variable = Instantiate<GameObjectVariable>(baseGameObject);
        variable.SetValue(gameObjectEntity.gameObject);
        Add(gameObjectEntity.entity, variable);
    }
}
