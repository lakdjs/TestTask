using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootStrapper : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private InputListener inputListener;
    [SerializeField] private float movePower;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float moveSpeed;
    [SerializeField] private PlayerMovement _movement;
    [SerializeField] private Rigidbody2D _rigidbody2;

    private IMoveState _moveState;
    private void Awake()
    {
        SetUp();
    }
    private void SetUp()
    {
        _moveState = new MovingDown();
        _movement.Construct(_moveState, moveSpeed, playerTransform, _rigidbody2);
        player.Construct(playerTransform, movePower);
        inputListener.Construct(player, _movement);
    }
}
