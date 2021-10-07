using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System;

public class UseFlashlight : MonoBehaviour
{
    [SerializeField] FloatReference lightDecay;
    [SerializeField] FloatReference angleDecay;

    [SerializeField] FloatReference mininumAngle;

    [SerializeField] new Light light;

    [SerializeField] FloatEventReference onLightReload;
    void Start()
    {
        var baseAngle = light.spotAngle;
        var baseIntensity = light.intensity;
        onLightReload.Event
        .Observe()
        .TakeUntilDisable(this)
        .Subscribe((f) =>
        {
            light.intensity += f * lightDecay;

            light.spotAngle += f * angleDecay;

            light.intensity = Mathf.Min(light.intensity, baseIntensity);
            light.spotAngle = Mathf.Min(light.spotAngle, baseAngle);
        });
        Observable
        .Timer(TimeSpan.FromSeconds(1.0f))
        .Repeat()
        .TakeUntilDisable(this)
        .Subscribe((d) =>
        {
            DecreaseAngle();
            DecreaseIntensity();
        });
    }
    void DecreaseAngle()
    {

        light.spotAngle -= angleDecay.Value;
        light.spotAngle = Mathf.Max(light.spotAngle, mininumAngle.Value);
    }

    void DecreaseIntensity()
    {
        light.intensity -= lightDecay.Value;
    }
}
