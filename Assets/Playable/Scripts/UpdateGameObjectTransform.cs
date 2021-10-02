using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/MonoHooks/UpdateGameObjectPosition")]
class UpdateGameObjectTransform: GameObjectAction {
    [SerializeField] Vector3Variable position;
    override public void Do(GameObject obj) {
        position.Value = obj.transform.position;
    }

}