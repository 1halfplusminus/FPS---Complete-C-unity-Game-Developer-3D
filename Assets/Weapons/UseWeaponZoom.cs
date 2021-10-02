using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
using Cinemachine;
using UnityEngine.Assertions;

public class UseWeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCameraReference zoomInCameraReference;
    [SerializeField] CinemachineVirtualCameraReference zoomOutCameraReference;
    [SerializeField] FloatEventReference onZoom;

    [SerializeField] WeaponReference weapon;
    // Start is called before the first frame update
    void Start()
    {
        var weaponChange = weapon
        .ObserveEveryValueChanged((w) => w.Value);
        weaponChange
          .TakeUntilDisable(this)
          .Subscribe((w) =>
              {
                  if (zoomInCameraReference.Value.enabled)
                  {
                      onZoom.Event.Raise(1f);
                  }
                  zoomInCameraReference.Value.m_Lens.FieldOfView = zoomOutCameraReference.Value.m_Lens.FieldOfView - w.zoom;
              }
          );
        //TODO: Raise onZoomIn and onZoomOut Event and add a script on the camera that listen to this event

        onZoom.Event.Observe()
        .TakeUntilDisable(this)
        .Subscribe((x) =>
         {
             if (x > 0 && weapon.Value.zoom > 0)
             {
                 var zoomingIn = zoomOutCameraReference.Value.enabled;
                 if (zoomingIn)
                 {
                     zoomOutCameraReference.Value.enabled = false;
                     zoomInCameraReference.Value.enabled = true;
                 }
                 else
                 {
                     zoomInCameraReference.Value.enabled = false;
                     zoomOutCameraReference.Value.enabled = true;
                 }
             }
         });
    }

}
