using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This thing's position (camera) should be the same as the car's position
 */
public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    private static readonly Vector3 cameraOffset = new Vector3(0, 0, -10);


    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + cameraOffset;
    }
}
