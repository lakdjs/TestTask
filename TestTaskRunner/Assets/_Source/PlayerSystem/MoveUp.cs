using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : IMoveState
{
    public void Move(Transform player, float speed, Rigidbody2D rb)
    {
        rb.gravityScale = -0.33f;
    }

}
