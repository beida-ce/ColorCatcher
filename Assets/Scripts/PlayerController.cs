using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    private float xLimit;

    void Start()
    {
        // Kamera geniþliðinin yarýsýný hesapla (world space)
        xLimit = Camera.main.orthographicSize * Camera.main.aspect;
        float spriteHalfWidth = 2f; // sprite geniþliðine göre ayarlandý
        xLimit -= spriteHalfWidth;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveX * moveSpeed * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -xLimit, xLimit);
        transform.position = pos;
    }
}
