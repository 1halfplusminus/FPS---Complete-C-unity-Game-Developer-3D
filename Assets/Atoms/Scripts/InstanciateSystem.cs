

using UnityEngine;
using UnityAtoms.BaseAtoms;
public class InstanciateSystem : MonoBehaviour
{
    [SerializeField] GameObjectTransformEventReference onInstanciate;

    void Awake()
    {
        onInstanciate.Event.Register(Instantiate);
    }

    void Instantiate(GameObjectTransform gameObjectTransform)
    {
        Instantiate(gameObjectTransform.gameObject, gameObjectTransform.transform);
    }
}