using UnityEngine;

public class ColorMatch : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpriteRenderer playerColor = collision.GetComponent<SpriteRenderer>();
            SpriteRenderer myColor = GetComponent<SpriteRenderer>();

            if (playerColor != null && myColor != null)
            {
                if (playerColor.color == myColor.color)
                {
                    Debug.Log("Doðru renk! +1");
                    gameManager.AddScore(1);  // Puan ekle
                    
                }
                else
                {
                    Debug.Log("Yanlýþ renk!");
                }
            }
            Destroy(gameObject);
        }
    }
}
