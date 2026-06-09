using UnityEngine;

public class Pit : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 구덩이에 빠졌습니다!");
            // 플레이어가 구덩이에 빠졌을 때의 처리 (예: 체력 감소, 위치 초기화 등)
        }
    }
}
