using ScriptableObjectArchitecture;
using UnityEngine;

public class AvatarHealth : MonoBehaviour
{
    [SerializeField] FloatReference currentHealth = null;
    [SerializeField] FloatReference maxHealth = null;

    private void Awake()
    {
        currentHealth.Value = maxHealth.Value;
    }

    public void HealthChanged()
    {
        Debug.Log("AvatarHealth::HealthChanged currentHealth changed: " + currentHealth.Value);
        if (currentHealth.Value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
