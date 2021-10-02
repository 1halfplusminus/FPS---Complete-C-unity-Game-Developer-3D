using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityAtoms.BaseAtoms;

public class CinemachinePOVExtension : CinemachineExtension
{
    [SerializeField]
    Vector2Variable aimAt;

    [SerializeField]
    float clampAngle = 60f;

    [SerializeField]
    Vector2 speed = new Vector2(60f, 30f);


    private Vector3 startingRotation;
    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, 
    CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if(vcam.Follow  && stage == CinemachineCore.Stage.Aim ) {
            var delta = aimAt.Value * speed * Time.deltaTime;
            startingRotation = getStartingRotation();
            startingRotation.x +=  delta.x;
            startingRotation.y += delta.y;
            startingRotation.y = Mathf.Clamp(startingRotation.y,-clampAngle,clampAngle);
            state.RawOrientation = Quaternion.Euler(-startingRotation.y,startingRotation.x,0f);
        }
    }

    Vector3 getStartingRotation() {
        if(startingRotation == null) {
            startingRotation = transform.localRotation.eulerAngles;
        }
        return startingRotation;
    }
}
