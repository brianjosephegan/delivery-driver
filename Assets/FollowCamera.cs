using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followTarget;

    // Update is called once per frame
    private void LateUpdate()
    {
        transform.position = followTarget.transform.position + new Vector3(0, 0, -10f);
    }
}
