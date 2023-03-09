using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] KeyCode keyOne = KeyCode.W;
    [SerializeField] KeyCode keyTwo = KeyCode.S;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate()
    {

        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }

        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
    }
}
