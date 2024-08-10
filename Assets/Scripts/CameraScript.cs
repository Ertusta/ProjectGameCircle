using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Takip edilecek karakterin transform'u

    private Vector3 initialOffset;

    void Start()
    {
        // Kameran�n ba�lang��taki offset'ini hesapla
        initialOffset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Karakterden �u anki uzakl��� hesapla
        Vector3 currentOffset = initialOffset;
        Vector3 desiredPosition = target.position + currentOffset;

        // Kameray� do�rudan yeni pozisyona ayarla
        transform.position = desiredPosition;

  
    }
}
