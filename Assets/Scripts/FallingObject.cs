using UnityEngine;

public class FallingObject : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject); // Ekrandan ��karsa yok olsun
        }
    }
}
