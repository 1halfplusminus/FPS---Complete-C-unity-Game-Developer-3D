using Cinemachine;
using UnityAtoms.BaseAtoms;
using UnityEngine;


public class AtomCinemachineInputProvider : MonoBehaviour, AxisState.IInputAxisProvider
{
    /// <summary>Vector2 action for XY movement</summary>
    [Tooltip("Vector2 action for XY movement")]
    public Vector2Variable XYAxis;

    /*     /// <summary>Float action for Z movement</summary>
        [Tooltip("Float action for Z movement")]
        public InputActionReference ZAxis;
     */
    /// <summary>
    /// Implementation of AxisState.IInputAxisProvider.GetAxisValue().
    /// Axis index ranges from 0...2 for X, Y, and Z.
    /// Reads the action associated with the axis.
    /// </summary>
    /// <param name="axis"></param>
    /// <returns>The current axis value</returns>
    public virtual float GetAxisValue(int axis)
    {
        if (enabled)
        {
            switch (axis)
            {
                case 0: return XYAxis.Value.x;
                case 1: return XYAxis.Value.y;
                    /*      case 2: return XYZAxis.Value.y; */
            }
        }
        return 0;
    }
}