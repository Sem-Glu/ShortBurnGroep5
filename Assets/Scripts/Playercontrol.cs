using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{    
    private Rigidbody m_rb;

    [Header("Values")]
    private Vector3 m_Movement;
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_GroundDrag;

    [Header("Ground Check")]
    private bool Isgrounded;
    [SerializeField] private float m_Playerheight;
    [SerializeField] private LayerMask m_GroundLayer;

    private void Start()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        m_Movement.x = Input.GetAxisRaw("Horizontal");
        m_Movement.z = Input.GetAxisRaw("Vertical");

        //Check if grounded
        Isgrounded = Physics.Raycast(transform.position, Vector3.down, m_Playerheight * 0.5f + 0.2f, m_GroundLayer);

        if (Isgrounded)
            m_rb.drag = m_GroundDrag;
        else
            m_rb.drag = 0;
    }

    private void FixedUpdate()
    {
        m_rb.AddForce(m_Movement *(m_Speed * 10f), ForceMode.Force);
    }

}
