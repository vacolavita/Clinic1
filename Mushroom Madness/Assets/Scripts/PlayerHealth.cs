using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 4;
    private int currentHealth;
    public float damageInterval = 3f;
    private float lastDamageTime;
    public TMP_Text healthText;

    void Start()
    {
        currentHealth = maxHealth;
        healthText.text = "Health: " + currentHealth.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (Time.time - lastDamageTime > damageInterval)
            {
                lastDamageTime = Time.time;
                currentHealth--;
                healthText.text = "Health: " + currentHealth.ToString();

                if (currentHealth <= 0)
                {
                    currentHealth = maxHealth;
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}