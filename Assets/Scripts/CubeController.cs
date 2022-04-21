using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private LayerMask m_CubeLayer;

    private bool SeeCube;

    private void Update()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, Mathf.Infinity, m_CubeLayer))
        {
            Debug.Log("You hit a Controlabe Cube");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("Wow je hebt geklicked");
                hit.transform.position += Vector3.up * 10;
            }
        }
    }
}
