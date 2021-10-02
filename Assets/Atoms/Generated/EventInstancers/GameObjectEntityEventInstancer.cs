using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `GameObjectEntity`. Inherits from `AtomEventInstancer&lt;GameObjectEntity, GameObjectEntityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/GameObjectEntity Event Instancer")]
    public class GameObjectEntityEventInstancer : AtomEventInstancer<GameObjectEntity, GameObjectEntityEvent> { }
}
