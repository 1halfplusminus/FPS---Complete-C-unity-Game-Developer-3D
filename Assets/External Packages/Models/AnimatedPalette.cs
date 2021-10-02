using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPalette : MonoBehaviour
{
    public void Angry(int angry)
    {

        var _renderer = GetComponent<Renderer>();
        var propBlock = new MaterialPropertyBlock();
        propBlock.SetInteger("_Angry", angry);
        // Apply the edited values to the renderer.
        _renderer.SetPropertyBlock(propBlock);
    }
}
