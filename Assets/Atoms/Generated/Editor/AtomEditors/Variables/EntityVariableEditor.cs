using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Entity`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(EntityVariable))]
    public sealed class EntityVariableEditor : AtomVariableEditor<Entity, EntityPair> { }
}
