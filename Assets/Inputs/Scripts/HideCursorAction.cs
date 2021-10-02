using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Inputs/Hide Cursors")]
public class HideCursorAction : BoolAction
{
    public override void Do(bool cursorVisible)
    {
        Cursor.visible = cursorVisible;
    }
}

