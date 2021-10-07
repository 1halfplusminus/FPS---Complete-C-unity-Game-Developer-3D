using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using UniRx;
using UniRx.Triggers;
public class DisableMouseTrackingNoFocus : MonoBehaviour
{
    bool inputDisabled;
    // Start is called before the first frame update
    public void ToogleInputs()
    {
        var atomInputProviders = FindObjectsOfType<AtomCinemachineInputProvider>();

        foreach (var atomInputProvider in atomInputProviders)
        {
            inputDisabled = !atomInputProvider.enabled;
            atomInputProvider.enabled = inputDisabled;

        }
    }

    public void EnableInputIfDisable()
    {
        if (inputDisabled)
        {
            ToogleInputs();
        }
    }
}
