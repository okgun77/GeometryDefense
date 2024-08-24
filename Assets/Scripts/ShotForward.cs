using UnityEngine;

public class ShotForward : MonoBehaviour
{
    [SerializeField]
    private float shotSpeed = 2.0f;

    private void Update()
    {
        // 발사체를 위로 이동
        transform.Translate(Vector2.up * shotSpeed * Time.deltaTime);

        // 화면을 벗어나면 발사체 삭제
        if (transform.position.y > Camera.main.orthographicSize + 1)
        {
            Destroy(gameObject);
        }
    }


}
