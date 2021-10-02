
using UnityEngine;
using UnityAtoms.BaseAtoms;


public class EntityMono : MonoBehaviour, IEntity
{

    [SerializeField] GameObjectEntityEventReference onAttachEntityToGameObject;
    [SerializeField] EntityReference Id;
    [SerializeField] VoidBaseEventReference onInit;
    string IEntity.Id => Id.Value.Id;

    void OnDestroy()
    {
        onInit.Event.Unregister(AttachGameObjectToEntity);
    }
    void Awake()
    {
        onInit.Event.Register(AttachGameObjectToEntity);
    }
    void OnEnable()
    {
        AttachGameObjectToEntity();
    }
    void AttachGameObjectToEntity()
    {
        Id.Value = new Entity { Id = gameObject.GetInstanceID().ToString() };
        Debug.Log(Time.time + ": Attach entity to gameObject" + Id.Value);

        var gameObjectEntity = new GameObjectEntity() { entity = Id.Value, gameObject = gameObject };

        onAttachEntityToGameObject.Event.Raise(gameObjectEntity);
    }

}
