using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
public class WhenPlayerReachZeroHealth : MonoBehaviour
{
    [SerializeField] IntEventReference onHealthChange;
    [SerializeField] StringEventReference onPlayerDeath;
    // Start is called before the first frame update

    void Start()
    {
        onHealthChange.Event.Register(HealthChanged);
    }
    void OnDisable()
    {
        onHealthChange.Event.Unregister(HealthChanged);
    }
    void HealthChanged(int h)
    {
        if (h <= 0)
        {
            Debug.Log("Player just died");
            // TODO: Manage player ID
            onPlayerDeath.Event.Raise("1");
        }
    }
}
