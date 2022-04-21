using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    [SerializeField] private float m_SensX;
    [SerializeField] private float m_SensY;
    [SerializeField] private Transform m_Player;

    private float m_Xrot;
    private float m_Yrot;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * m_SensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * m_SensY;

        m_Yrot += mouseX;

        m_Xrot -= mouseY;
        m_Xrot = Mathf.Clamp(m_Xrot, -90, 90);

        transform.rotation = Quaternion.Euler(m_Xrot, m_Yrot, 0f);
        m_Player.rotation = Quaternion.Euler(0f, m_Yrot, 0f);
    }
}
