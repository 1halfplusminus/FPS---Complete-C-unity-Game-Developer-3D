#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectTransform`. Inherits from `AtomDrawer&lt;GameObjectTransformEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectTransformEvent))]
    public class GameObjectTransformEventDrawer : AtomDrawer<GameObjectTransformEvent> { }
}
#endif
