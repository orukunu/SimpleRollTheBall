using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraFollower : MonoBehaviour
{
    public GameObject ballToFollow;
    Vector3 distanceBetween;

    // Start is called before the first frame update
    void Start()
    {
        distanceBetween = transform.position - ballToFollow.transform.position;        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ballToFollow.transform.position + distanceBetween;
    }
}
