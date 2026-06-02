using UnityEngine;
using KinematicCharacterController;
using KinematicCharacterController.Examples;


public class Animation_controller : MonoBehaviour
{
    public ExampleCharacterController characterController;

    public Animator animator;

    private void Update()
    {
        animator.SetFloat("Speed", new Vector3(characterController.Motor.Velocity.x, 0, characterController.Motor.Velocity.z).magnitude);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
        else
        {
            animator.ResetTrigger("Jump");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            if(Random.Range(0, 3) == 1)
            {
                animator.SetTrigger("Rest");
            }
            else
            {
                animator.SetTrigger("Idle2");
            }
        }
        else
        {
            animator.ResetTrigger("Rest");
            animator.ResetTrigger("Idle2");
        }

    }
}
