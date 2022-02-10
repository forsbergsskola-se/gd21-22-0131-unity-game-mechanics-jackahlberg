using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthContainer : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3;
    [SerializeField] public int currentHealth { get; private set; }
    [SerializeField] private AIDealDamage _aiDealDamage;
    [SerializeField] private PlayerDash playerDash;
    public bool isVulnerable;
    void Start()
    {
        currentHealth = maxHealth;
        isVulnerable = false;
    }

    private void Update()
    {
        CheckDamage();
    }

    private void CheckDamage()
    {

        if (_aiDealDamage.isHit && isVulnerable == false && !playerDash.isDashing)
        {
            isVulnerable = true;
            currentHealth -= 1;
            CheckHealth();
            _aiDealDamage.StartCoroutine(InvulnerableTimer());
        }

    }

    private void CheckHealth()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator InvulnerableTimer()
    {
        yield return new WaitForSeconds(3f);
        isVulnerable = false;
    }
}
