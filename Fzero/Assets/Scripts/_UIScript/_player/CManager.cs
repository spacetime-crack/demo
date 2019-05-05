using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CManager : MonoBehaviour
{
    private Transform target;
    private Vector3 targetPosition;
    private Vector3 offset = new Vector3(-1,4,-3);

    private void Start()
    {
        target = GameObject.Find("_B_Boy").GetComponent<Transform>();
    }
    private void LateUpdate()
    {
        //targetPosition = target.position + offset;
        //Vector3.Lerp(transform.position, targetPosition, 2 * Time.deltaTime);
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
