
using UnityEngine;
using UnityEngine.UI;

public class BonusCoinCounter : MonoBehaviour
{
    public Text bonusCoinText;
    private int collectedCoins = 0;

    private void Start()
    {
        UpdateText();
    }

    public void ResetCounter()
    {
        collectedCoins = 0;
        UpdateText();
    }

    public void CollectCoin()
    {
        collectedCoins++;

        if (collectedCoins > 50)
            collectedCoins = 50;

        UpdateText();
    }

    private void UpdateText()
    {
        if (bonusCoinText != null)
        {
            bonusCoinText.text =
                "BonusCoins: " + collectedCoins + "/50";
        }
    }
}
