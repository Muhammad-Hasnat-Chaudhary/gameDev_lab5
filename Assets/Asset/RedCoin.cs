
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    [Header("Blue Coin Settings")]
    public GameObject blueCoinPrefab;
    public int numberOfBlueCoins = 50;

    [Header("Platform Settings")]
    public float platformMinX = -9f;
    public float platformMaxX = 9f;
    public float platformMinZ = -9f;
    public float platformMaxZ = 9f;
    public float coinHeight = 0.5f;

    private bool collected = false;

    private void Start()
    {
        int score = Random.Range(1, 11);
        Debug.Log("Red Coin Score: " + score);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collected || !other.CompareTag("Player"))
            return;

        collected = true;

        for (int i = 0; i < numberOfBlueCoins; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(platformMinX, platformMaxX),
                coinHeight,
                Random.Range(platformMinZ, platformMaxZ)
            );

            Instantiate(
                blueCoinPrefab,
                randomPosition,
                Quaternion.identity
            );
        }

        Destroy(gameObject);
    }
}
