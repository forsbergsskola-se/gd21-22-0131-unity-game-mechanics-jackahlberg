using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private HealthContainer health;
    [SerializeField] private Text text;

    private void Update()
    {
        text.text = "Health: " + health.currentHealth;
    }

}
