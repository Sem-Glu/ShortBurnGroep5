using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFolower : MonoBehaviour
{
    [SerializeField] private Transform m_Player;
    [SerializeField] private Vector3 m_Offset;

    private void Update()
    {
        transform.position = m_Player.position + m_Offset;
    }
}
