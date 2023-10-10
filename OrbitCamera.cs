using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    [SerializeField] private Transform target;
    [SerializeField] private float rotationSpeed;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //lay su dicchuyen cua con chuot
            float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed;

            target.Rotate(Vector3.up * horizontalInput);

            transform.position = target.transform.position + offset;
        }
    }
}
