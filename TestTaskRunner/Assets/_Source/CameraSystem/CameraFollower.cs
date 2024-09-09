using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    private Vector3 offset;
    private void Awake()
    {
        offset = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position =new Vector3((targetTransform.transform.position ).x,0) + offset;
    }
}
