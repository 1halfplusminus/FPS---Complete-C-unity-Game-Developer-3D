using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Hit`. Inherits from `AtomEventInstancer&lt;Hit, HitEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Hit Event Instancer")]
    public class HitEventInstancer : AtomEventInstancer<Hit, HitEvent> { }
}
