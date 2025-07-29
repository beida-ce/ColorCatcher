using UnityEngine;
using UnityEngine.UI;  // UI kullan�m� i�in ekle
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject[] fallingPrefabs;
    public float spawnInterval = 1f;

    public TMP_Text scoreText; // Inspector'dan ba�lanacak UI Text referans�
    private int score = 0;

    private float xSpawnLimit;

    void Start()
    {
        xSpawnLimit = Camera.main.orthographicSize * Camera.main.aspect;

        float spriteHalfWidth = 0.5f;
        xSpawnLimit -= spriteHalfWidth;

        InvokeRepeating(nameof(SpawnFallingObject), 1f, spawnInterval);

        UpdateScoreText();
    }

    void SpawnFallingObject()
    {
        int index = Random.Range(0, fallingPrefabs.Length);
        float randomX = Random.Range(-xSpawnLimit, xSpawnLimit);
        Vector3 spawnPos = new Vector3(randomX, 6f, 0);
        Instantiate(fallingPrefabs[index], spawnPos, Quaternion.identity);
    }

    // Puan art�rma metodu
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // UI Text g�ncelleme
    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Puan: " + score;
    }
}
