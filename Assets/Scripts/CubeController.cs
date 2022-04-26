using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    [SerializeField] private LayerMask m_CubeLayer;
    [SerializeField] private TextMeshProUGUI m_PowerText;
    [SerializeField] private float m_PowerScale;
    [SerializeField] private float m_MovePower = 0;

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

        PowerController();

        if(m_SeeCube == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (hit.transform.CompareTag("Vertical"))
                {
                    //move the cube Vertical
                    hit.transform.position += Vector3.up * m_MovePower;
                }
                else if (hit.transform.CompareTag("Horizontal"))
                {
                    //move the cube Horizontal
                    hit.transform.position += Vector3.left * m_MovePower;
                }
                else if (hit.transform.CompareTag("Forward"))
                {
                    //move the cube Forwards
                    hit.transform.position += Vector3.forward * m_MovePower;
                }
            }

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                if (hit.transform.CompareTag("Vertical"))
                {
                    //move the cube Vertical
                    hit.transform.position -= Vector3.up * m_MovePower;
                }
                else if (hit.transform.CompareTag("Horizontal"))
                {
                    //move the cube Horizontal
                    hit.transform.position -= Vector3.left * m_MovePower;
                }
                else if (hit.transform.CompareTag("Forward"))
                {
                    //move the cube backwards
                    hit.transform.position -= Vector3.forward * m_MovePower;
                }
            }
        }       
    }

    private void PowerController()
    {
        m_MovePower += Input.mouseScrollDelta.y * m_PowerScale;
        m_PowerText.text = m_MovePower.ToString();

        if (m_MovePower > 10)
        {
            m_MovePower = 10;
        }
        else if (m_MovePower < 0)
        {
            m_MovePower = 0;
        }
    }
}
