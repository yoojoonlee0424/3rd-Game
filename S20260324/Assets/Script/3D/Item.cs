using UnityEngine;

public class Item : MonoBehaviour
{
    public int scoreValue = 10; // 아이템이 제공하는 점수 값

    public bool isSpeedItem = true; // 아이템이 스피드 아이템인지 여부
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player_Item playerItem = other.GetComponent<player_Item>();
            if(isSpeedItem)
            {
                playerItem.speedItem(); // 플레이어의 speedItem 메서드 호출
            }
            

            //점수 증가
            GameController gameController = FindObjectOfType<GameController>();
            if (gameController != null)
            {
                gameController.AddScore(scoreValue); // 점수 추가
            }

            Debug.Log("아이템 획득!");
            Destroy(gameObject); // 아이템 오브젝트 제거
        }
    }   

}
