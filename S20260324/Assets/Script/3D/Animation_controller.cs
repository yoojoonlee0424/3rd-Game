using KinematicCharacterController;
using KinematicCharacterController.Examples;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class Animation_controller : MonoBehaviour
{
    public ExampleCharacterController characterController;

    public Animator animator;

    [SerializeField] private float animationSmoothTime = 0.1f;
    private float _animationBlend;



    private void Update()
    {
        /*
        Vector3 characterVelocity = characterController.Motor.Velocity;

        // 플랫폼(AttachedRigidbody) 속도 제거
        if (characterController.Motor.AttachedRigidbody != null)
        {
            characterVelocity -= characterController.Motor.AttachedRigidbody.linearVelocity;
        }

        // 수평 속도만 사용
        float speed = new Vector3(characterVelocity.x, 0f, characterVelocity.z).magnitude;

        float maxSpeed = 5.335f;
        float normalizedSpeed = Mathf.Clamp01(speed / maxSpeed);

        _animationBlend = Mathf.Lerp(_animationBlend, normalizedSpeed, Time.deltaTime / animationSmoothTime);

        if (_animationBlend < 0.01f) _animationBlend = 0f;

        animator.SetFloat("Speed", _animationBlend);
        */
        
        MoveAni();
        inAir();
        JumpAni();
        RestAni();

    }

    private void MoveAni()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetFloat("Speed", new Vector3(characterController.Motor.Velocity.x, 0, characterController.Motor.Velocity.z).magnitude / 4);
        }
        else
        {
            animator.SetFloat("Speed", 0);
            return;
        }
        
    }

    private void inAir()
    {
        if (characterController.Motor.GroundingStatus.IsStableOnGround)
        {
            return;
        }
        else
        {
            animator.SetFloat("InAir", characterController.Motor.Velocity.y);
        }
    }



    private void JumpAni()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
        else
        {
            animator.ResetTrigger("Jump");
        }
    }

    private void RestAni()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Random.Range(0, 3) == 1)
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
