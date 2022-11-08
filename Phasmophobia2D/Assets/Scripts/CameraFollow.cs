using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 10f;
    public Transform target;
    public float Offset;

    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y +Offset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
