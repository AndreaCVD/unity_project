using UnityEngine;

public class control_speed : MonoBehaviour
{

    Animator animator;
    float Speed = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            Speed += 0.0025f;

            animator.SetFloat("Speed", Speed);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            Speed -= 0.0025f;

            if (Speed < 0)
            {
                Speed = 0;
                animator.SetFloat("Speed", Speed);
            }
            else
            {
                animator.SetFloat("Speed", Speed);
            }

        }
    }
}
