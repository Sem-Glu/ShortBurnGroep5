using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private LayerMask m_CubeLayer;

    private bool m_SeeCube;

    private void Update()
    {
        //check if the player is looking at a interactable cube
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, Mathf.Infinity, m_CubeLayer))
        {
            m_SeeCube = true;
        }
        else
        {
            m_SeeCube = false;
        }


        if(m_SeeCube == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //move the cube
                hit.transform.position += Vector3.up * 5;
            }

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                //move the cube
                hit.transform.position -= Vector3.up * 5;
            }
        }       
    }
}
