using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

using UniRx;

public class SyncPosition : MonoBehaviour
{
    [SerializeField]
    Vector3Reference position;
    // Start is called before the first frame update
    void Start()
    {
        transform
        .ObserveEveryValueChanged(x => x.position)
        .TakeUntilDisable(this)
        .Subscribe((p) => position.Value = p);
    }
}
