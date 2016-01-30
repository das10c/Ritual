using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class health : MonoBehaviour {

    public float maxHealth = 100;
    public float currentHealth = 100;
    Image healthBar;

    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    public void updateHealth(float amount)
    {
        currentHealth += amount;
        healthBar.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0)
        {
            MySceneManager.EndGame();
        }
    }
}
