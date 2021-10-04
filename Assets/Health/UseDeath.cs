using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UniRx;
public class UseDeath : MonoBehaviour
{

    // TODO: Use a scriptable object for death condition
    [SerializeField] VoidBaseEventReference onDeath;

    [SerializeField] IntEventReference onHealthChanged;


    // Start is called before the first frame update
    void Start()
    {
        onHealthChanged.Event
        .Observe()
        .TakeUntilDestroy(this)
        .Subscribe((h) =>
        {
            if (h <= 0)
            {
                Debug.Log(gameObject.name + " is dead");
                onDeath.Event.Raise();
            }
        });
    }


}
