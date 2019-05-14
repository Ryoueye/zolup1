using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody : MonoBehaviour {
    Rigidbody m_Rigidbody;
    Vector3 m_ZAxis;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        //This locks the RigidBody so that it does not move or rotate in the z axis (can be seen in Inspector).
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
        //Set up vector for moving the Rigidbody in the z axis
        m_ZAxis = new Vector3(0, 0, 5);
    }

    void Update()
    {
        //Press space to remove the constraints on the RigidBody
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Remove all constraints
            m_Rigidbody.constraints = RigidbodyConstraints.None;
        }

        //Press the right arrow key to move positively in the z axis if the constraints are removed
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //If the constraints are removed, the Rigidbody moves along the z axis
            //If the constraints are there, no movement occurs
            m_Rigidbody.velocity = m_ZAxis;
        }

        //Press the left arrow key to move negatively in the z axis if the constraints are removed
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_Rigidbody.velocity = -m_ZAxis;
        }
    }
}
