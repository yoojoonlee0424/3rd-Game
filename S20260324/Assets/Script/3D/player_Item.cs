using KinematicCharacterController.Examples;
using UnityEngine;

public class player_Item : MonoBehaviour
{
    public ExampleCharacterController characterController;

    public float speedBoostAmount = 15f; // 이동 속도 증가량

    

    public void speedItem()
    {
        characterController.MaxStableMoveSpeed += speedBoostAmount; 
        Debug.Log("속도 아이템 획득! 이동 속도가 증가합니다.");

        Invoke("ResetSpeed", 5f); // 5초 후에 이동 속도를 초기화
    }

    private void ResetSpeed()
    {
        characterController.MaxStableMoveSpeed -= speedBoostAmount;
        Debug.Log("속도 아이템 효과 종료. 이동 속도가 원래대로 돌아갑니다.");
    }
}