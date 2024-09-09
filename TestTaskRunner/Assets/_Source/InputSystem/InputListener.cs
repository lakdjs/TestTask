using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    private Player _player;
    private PlayerMovement _movement;
    public void Construct(Player player, PlayerMovement movement)
    {
        _player = player;
        _movement = movement;
    }
    void Update()
    {
        ReadMove();
    }
    private void ReadMove()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            _movement.ChangeState(new MoveUp());
        }
        else if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            _movement.ChangeState(new MovingForward());
        }
    }
}
