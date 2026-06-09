using UnityEngine;

public class Finsh : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("게임 클리어!");
            // 게임 클리어 처리 (예: 씬 전환, UI 표시 등)
            GameController gameController = FindObjectOfType<GameController>();
            gameController.GameClear();
        }
    }
}
