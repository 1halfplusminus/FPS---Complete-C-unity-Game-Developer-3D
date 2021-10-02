#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `GameObjectEntity`. Inherits from `AtomEventEditor&lt;GameObjectEntity, GameObjectEntityEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(GameObjectEntityEvent))]
    public sealed class GameObjectEntityEventEditor : AtomEventEditor<GameObjectEntity, GameObjectEntityEvent> { }
}
#endif
