using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/MonoHooks/Inputs/Hide Cursors")]
public class HideCursorHookAction : GameObjectAction
{
    [SerializeField]
    BoolVariable hideCursor;
    public override void Do(GameObject obj)
    {
        hideCursor.Value = false;

    }
}