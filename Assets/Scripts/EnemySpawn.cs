using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;     // 적 프리팹
    [SerializeField]    
    private float spawnInterval = 2f;   // 적 생성 간격
    [SerializeField]
    private float xMargin = 0.5f;       // 화면 좌우 끝 여백 값

    private float screenLeft;           // 화면 왼쪽 끝 x 좌표
    private float screenRight;          // 화면 오른쪽 끝 x 좌표

    private void Start()
    {
        // 카메라의 화면 좌우 끝 좌표 계산
        float halfHeight = Camera.main.orthographicSize;
        float halfWidth = halfHeight * Camera.main.aspect;

        screenLeft = -halfWidth + xMargin;
        screenRight = halfWidth - xMargin;

        // 일정한 간격으로 적을생성하는 반복 호출
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }


    private void SpawnEnemy()
    {
        // 적의 x 좌표를 화면 좌우 끝 사이에서 무작위로 결정
        float xPosition = Random.Range(screenLeft, screenRight);
        Vector2 spawnPosition = new Vector2(xPosition, Camera.main.orthographicSize + 1);

        // 적 생성
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

    }

}
