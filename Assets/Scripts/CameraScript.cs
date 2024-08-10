using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Takip edilecek karakterin transform'u

    private Vector3 initialOffset;

    void Start()
    {
        // Kameranýn baþlangýçtaki offset'ini hesapla
        initialOffset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Karakterden þu anki uzaklýðý hesapla
        Vector3 currentOffset = initialOffset;
        Vector3 desiredPosition = target.position + currentOffset;

        // Kamerayý doðrudan yeni pozisyona ayarla
        transform.position = desiredPosition;

  
    }
}
