using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;

    private bool isStopped = false;

    private void Update()
    {
        if (!isStopped)
        {
            // 적 오브젝트를 하단으로 이동
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        // 화면을 벗어나면 적 오브젝트 삭제
        if (transform.position.y < -Camera.main.orthographicSize -1)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.CompareTag("Wall"))
        {
            isStopped = true;  // 트리거에 닿으면 이동 멈춤
            // 이 시점에서 공격 애니메이션을 시작하거나, 적의 다른 행동을 유발할 수 있음
        }
    }

}
