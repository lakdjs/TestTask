using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour 
{
    private float _speed;
    private Transform _player;
    private Rigidbody2D _playerRB;
    public IMoveState moveState { get; private set; }

    public void Construct (IMoveState moveState, float speed, Transform player, Rigidbody2D playerRB)
    {
        this.moveState = moveState;
        _speed = speed;
        _player = player;
        _playerRB = playerRB;
    }
    private void Update()
    {

        Move();
    }
    public void ChangeState(IMoveState state)
    {
        moveState = state;
    }
    private void Move()
    {
        _player.position = Vector2.MoveTowards(_player.position, _player.position + _player.right, _speed * Time.deltaTime);
        moveState.Move(_player, _speed, _playerRB);
    }
}
