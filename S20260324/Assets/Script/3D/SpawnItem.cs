using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public float spawnInterval = 5f; // 아이템 생성 간격 (초)
    public float spawnPositionX = 5f; 
    public float spawnPositionY = 1f;
    public float spawnPositionZ = 0f;

    public bool isSpawning = true; // 아이템 생성 여부를 제어하는 변수
    public bool isSpawnOnObject = false; 

    private GameObject spawner;
    private float timer;
    private float currentPositionX;
    private float currentPositionY;
    private float currentPositionZ;

    private Vector3 spawnPosition;
    private Quaternion spawnRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GameObject.Find("Spawner"); // "Spawner"라는 이름의 게임 오브젝트를 찾음

        Spawn(); // 게임 시작 시 아이템을 생성
    }

    // Update is called once per frame
    void Update()
    {
        
        updatePos(); // 위치 업데이트

        if (isSpawning)
        {
            timer += Time.deltaTime; // 타이머에 경과 시간을 더함
            if (timer >= spawnInterval)
            {
                Spawn(); // 아이템 생성
                timer = 0f; // 타이머 초기화
            }
        }
    }

    public void Spawn()
    {

        // 아이템 프리팹을 로드하여 생성
        GameObject itemPrefab = Resources.Load<GameObject>("Prefab/SpeedItem"); // Resources 폴더에 있는 아이템 프리팹 경로
        if (itemPrefab != null)
        {
            Instantiate(itemPrefab, spawnPosition, spawnRotation);
            Debug.Log("아이템이 생성되었습니다.");
        }
        else
        {
            Debug.LogError("아이템 프리팹을 찾을 수 없습니다.");
        }
    }

    private void updatePos()
    {
        transform.position = new Vector3(currentPositionX, currentPositionY, currentPositionZ); // 스포너의 위치 설정

        spawnRotation = Quaternion.identity; // 기본 회전

        // 아이템을 생성할 위치와 회전을 설정
        if (isSpawnOnObject)
        {
            spawnPosition = new Vector3(currentPositionX, currentPositionY, currentPositionZ); //업데이트 위치
        }
        else
        {
            spawnPosition = new Vector3(spawnPositionX, spawnPositionY, spawnPositionZ); //고정 위치
        }
       

    }




}
