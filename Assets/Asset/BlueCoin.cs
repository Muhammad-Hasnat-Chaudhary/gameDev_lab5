
using UnityEngine;

public class BlueCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        BonusCoinCounter counter =
            FindFirstObjectByType<BonusCoinCounter>();

        if (counter != null)
        {
            counter.CollectCoin();
        }

        Destroy(gameObject);
    }
}
