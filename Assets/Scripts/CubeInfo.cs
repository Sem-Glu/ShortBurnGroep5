using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInfo : MonoBehaviour
{
    [Header("Materials")]
    [SerializeField] private Material m_Red;
    [SerializeField] private Material m_Blue;
    [SerializeField] private Material m_Yellow;

    public enum m_State {Horizontal, Vertical, Forward}
    public m_State m_CurrentState;

    private void Update()
    {
        if (m_CurrentState == m_State.Horizontal)
        {
            this.GetComponent<MeshRenderer>().material = m_Blue;
            gameObject.tag = "Horizontal";
        }
        else if (m_CurrentState == m_State.Vertical)
        {
            this.GetComponent<MeshRenderer>().material = m_Red;
            gameObject.tag = "Vertical";
        }
        else if (m_CurrentState == m_State.Forward)
        {
            this.GetComponent<MeshRenderer>().material = m_Yellow;
            gameObject.tag = "Forward";
        }
    }
}
