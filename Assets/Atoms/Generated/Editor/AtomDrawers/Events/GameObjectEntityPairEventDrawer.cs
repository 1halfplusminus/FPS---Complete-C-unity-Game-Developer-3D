#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectEntityPair`. Inherits from `AtomDrawer&lt;GameObjectEntityPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectEntityPairEvent))]
    public class GameObjectEntityPairEventDrawer : AtomDrawer<GameObjectEntityPairEvent> { }
}
#endif
