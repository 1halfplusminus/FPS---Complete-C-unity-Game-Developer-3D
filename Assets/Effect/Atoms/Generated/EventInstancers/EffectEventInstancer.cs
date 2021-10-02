using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Effect`. Inherits from `AtomEventInstancer&lt;Effect, EffectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Effect Event Instancer")]
    public class EffectEventInstancer : AtomEventInstancer<Effect, EffectEvent> { }
}
