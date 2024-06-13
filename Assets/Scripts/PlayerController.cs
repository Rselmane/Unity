using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float health;
    public int maxHealth;
    public float lastDamageTaken;
    public float regenCooldown;
    public List<int> keys = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < maxHealth && lastDamageTaken + regenCooldown >= Time.time)
        {
            health += 3 * Time.deltaTime;
        }
    }

    public void Damage(int damage)
    {
        if (health - damage < 0)
        {
            health = 0;
        } 
        else
        {
            health -= damage;
        }

        this.lastDamageTaken = Time.time;

        if (health < 0)
        {
            OnDeath();
        }
    }

    private void OnDeath()
    {
        // reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
