using UnityEngine;

public class FallingObject : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject); // Ekrandan çýkarsa yok olsun
        }
    }
}
