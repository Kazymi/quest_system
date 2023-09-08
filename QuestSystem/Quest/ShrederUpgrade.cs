using Kuhpik;
using UnityEngine;

public class ShrederUpgrade : MonoBehaviour
{
    private BuyPlace buyPlace;

    private void Awake()
    {
        buyPlace = GetComponent<BuyPlace>();
    }

    private void OnEnable()
    {
        buyPlace.Bought += Bought;
    }

    private void OnDisable()
    {
        buyPlace.Bought -= Bought;
    }

    private void Bought()
    {
        Bootstrap.Instance.PlayerData.CurrentShrederBuildLevel++;
        Bootstrap.Instance.SaveGame();
    }
}