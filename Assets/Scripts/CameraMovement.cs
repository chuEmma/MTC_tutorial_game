using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject followTarget; 
    private Vector3 targetPos;
    public float moveSpeed; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is always comes last
    void LateUpdate()
    {

        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);
        // if (transform.position != target.position) {
        //     Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        //     transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        // }
    }

    // public GameObject followTarget; 
    // private Vector3 targetPos;
    // public float moveSpeed; 

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
    //     transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);
    // }
}
