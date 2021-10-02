using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `AmmoSlot`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AmmoSlotVariable))]
    public sealed class AmmoSlotVariableEditor : AtomVariableEditor<AmmoSlot, AmmoSlotPair> { }
}
