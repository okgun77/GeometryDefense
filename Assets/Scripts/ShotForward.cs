using UnityEngine;

public class ShotForward : MonoBehaviour
{
    [SerializeField]
    private float shotSpeed = 2.0f;

    private void Update()
    {
        // �߻�ü�� ���� �̵�
        transform.Translate(Vector2.up * shotSpeed * Time.deltaTime);

        // ȭ���� ����� �߻�ü ����
        if (transform.position.y > Camera.main.orthographicSize + 1)
        {
            Destroy(gameObject);
        }
    }


}
