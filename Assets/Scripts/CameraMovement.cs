using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject followTarget; 
    private Vector3 targetPos;
    public float moveSpeed; 
    public Vector2 maxPosition;
    public Vector2 minPosition; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // LateUpdate is always comes last
    void LateUpdate()
    {

        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
        targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);
        transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

}
