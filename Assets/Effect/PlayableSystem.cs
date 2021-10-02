using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;
using System.Linq;
public class PlayableSystem : MonoBehaviour
{
    [SerializeField] AtomCollectionReference effects;

    [SerializeField] EffectEvent onEffect;

    // Start is called before the first frame update
    void Awake()
    {
        onEffect.Register(Play);
    }
    void Play(Effect effect)
    {
        var variable = effects.Collection.Value.Get<AtomBaseVariable>(effect.ID);
        if (variable is IPlayable p)
        {
            p.Play(effect);
        }
        else if (variable is AtomBaseVariable<GameObject> m)
        {
            Debug.Log("variable is not IPlayable" + m.Value.name);
        }

    }
}
