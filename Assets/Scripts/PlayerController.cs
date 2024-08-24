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
        // �߻� �Է� ���� & �߻�
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Fire();
            nextFireTime = Time.time + fireRate;
        }
        

    }

    private void Fire()
    {
        // �߻�ü ����
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
