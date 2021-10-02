using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    [SerializeField]
    private float playerSpeed = 2.0f;

    [SerializeField]
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    [SerializeField]
    Vector3Variable input;

    [SerializeField]
    BoolVariable jumping;

    [SerializeField]
    Vector3Variable cameraForward;

    [SerializeField]
    Vector3Variable cameraRight;

    [SerializeField]
    GameObjectReference weapon;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = input.Value;
        move = cameraForward.Value * move.z + cameraRight.Value * move.x;
        var targetPosition = weapon.Value.transform.position + cameraForward.Value;
        var direction = targetPosition - weapon.Value.transform.position;
        weapon.Value.transform.rotation = Quaternion.LookRotation(direction, controller.transform.up);
        controller.Move(move * Time.deltaTime * playerSpeed);
        // Changes the height position of the player..
        if (jumping.Value && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

    }
}
