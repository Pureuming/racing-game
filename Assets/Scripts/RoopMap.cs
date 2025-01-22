using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoopMap : MonoBehaviour
{
    [SerializeField] private float mapSpeed = 4.0f; 

    void Update()
    {
        transform.Translate(0, 0, -1 * mapSpeed * Time.deltaTime);

        if (transform.position.z <= -8)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 8);
        }
    }
}
