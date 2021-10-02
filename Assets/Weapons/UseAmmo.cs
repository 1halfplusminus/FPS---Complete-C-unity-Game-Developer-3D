using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
public class UseAmmo : MonoBehaviour
{
    [SerializeField] IntReference ammoAmount;

    [SerializeField] ShootEventReference onTriggerPressed;

    [SerializeField] ShootEventReference onShoot;


    // Start is called before the first frame update
    void Start()
    {
        onTriggerPressed.Event.Observe()
        .TakeUntilDisable(this)
        .Subscribe((shoot) =>
        {
            if (ammoAmount.Value > 0)
            {
                onShoot.Event.Raise(shoot);
                ammoAmount.Value -= 1;
            }
            else
            {
                Debug.Log("Not more ammo");
            }
        });
    }

}
