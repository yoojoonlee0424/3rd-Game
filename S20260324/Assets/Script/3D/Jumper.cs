using KinematicCharacterController.Examples;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpStrength = 10f; // 점프 강도


    private void OnTriggerEnter(Collider other)
    {
        ExampleCharacterController character = other.GetComponent<ExampleCharacterController>();
        character.AddVelocity(Vector3.up * jumpStrength); // 위로 향하는 벡터에 원하는 점프 강도를 곱하여 추가
    }
}
