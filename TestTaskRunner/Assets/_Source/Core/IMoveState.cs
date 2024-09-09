using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveState
{
   // void SetState(PlayerMovement movement);
    void Move(Transform player, float speed, Rigidbody2D rb);
}
