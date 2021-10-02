using UnityEngine;

using System;
using UnityAtoms.BaseAtoms;

public class PlayEffect : MonoBehaviour
{
    public void Play(DoEffectAtPivot playable)
    {
        playable.Play(gameObject);
    }
}