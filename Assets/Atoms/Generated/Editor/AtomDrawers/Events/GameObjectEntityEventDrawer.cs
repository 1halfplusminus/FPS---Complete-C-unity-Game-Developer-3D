#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectEntity`. Inherits from `AtomDrawer&lt;GameObjectEntityEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(GameObjectEntityEvent))]
    public class GameObjectEntityEventDrawer : AtomDrawer<GameObjectEntityEvent> { }
}
#endif
