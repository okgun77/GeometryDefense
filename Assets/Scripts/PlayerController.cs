using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private float fireRate = 0.5f;
    [SerializeField]
    float nextFireTime;

    private void Update()
    {
        // 발사 입력 감지 & 발사
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Fire();
            nextFireTime = Time.time + fireRate;
        }
        

    }

    private void Fire()
    {
        // 발사체 생성
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
