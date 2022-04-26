using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFolower : MonoBehaviour
{
    [SerializeField] private Transform m_Player;
    [SerializeField] private float m_Yoffset;

    private void Update()
    {
        //Sets the position of the camera to the position of the player with an offset
        transform.position = m_Player.position + new Vector3(0, m_Yoffset, 0);
    }
}
