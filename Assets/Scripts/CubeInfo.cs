using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInfo : MonoBehaviour
{
    private Rigidbody m_Rb;
    private Vector3 m_Direction;

    [Header("Materials")]
    [SerializeField] private Material m_Red;
    [SerializeField] private Material m_Blue;
    [SerializeField] private Material m_Yellow;

    [Header("States")]
    [SerializeField] private bool m_Moveing;
    public enum m_State {Horizontal, Vertical, Forward}
    public m_State m_CurrentState;

    private void Awake()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (m_CurrentState == m_State.Horizontal)
        {
            this.GetComponent<MeshRenderer>().material = m_Blue;
            gameObject.tag = "Horizontal";
            m_Direction = new Vector3(-1, 0, 0);
        }
        else if (m_CurrentState == m_State.Vertical)
        {
            this.GetComponent<MeshRenderer>().material = m_Red;
            gameObject.tag = "Vertical";
            m_Direction = new Vector3(0, -1, 0);
        }
        else if (m_CurrentState == m_State.Forward)
        {
            this.GetComponent<MeshRenderer>().material = m_Yellow;
            gameObject.tag = "Forward";
            m_Direction = new Vector3(0, 0, -1);
        }

        if (m_Moveing == true)
        {
        Move();
        }
    }

    private void Move()
    {
        m_Rb.AddForce(m_Direction, ForceMode.Force);
    }
}
