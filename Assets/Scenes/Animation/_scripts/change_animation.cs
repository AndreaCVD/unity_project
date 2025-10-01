using UnityEngine;

public class change_animation : MonoBehaviour
{
    Animator m_Animator;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
           // m_Animator.ResetTrigger("pressed_C");

            m_Animator.SetTrigger("pressed_S");
        }

        if (Input.GetKey(KeyCode.C))
        {
           // m_Animator.ResetTrigger("pressed_S");

            m_Animator.SetTrigger("pressed_C");
        }
    }
}
