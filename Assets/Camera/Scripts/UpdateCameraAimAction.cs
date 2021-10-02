using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Camera/UpdateAimVector")]
public class UpdateCameraAimAction : GameObjectAction
{
    [SerializeField]
    Vector3Reference cameraForward;

    [SerializeField]
    Vector3Reference cameraRight;
    [SerializeField] Vector3Reference cameraPosition;


    public override void Do(GameObject obj)
    {
        var cameraTransform = Camera.main.transform;
        cameraForward.Value = cameraTransform.forward;
        cameraRight.Value = cameraTransform.right;
        cameraPosition.Value = cameraTransform.position;

    }
}