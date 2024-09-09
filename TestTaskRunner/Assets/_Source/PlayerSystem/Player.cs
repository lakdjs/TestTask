using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _playerTransform;
    private float _movePower;
    public void Construct(Transform playerT, float moveP)
    {
        _playerTransform = playerT;
        _movePower = moveP;
    }
}
