using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHealth : MonoBehaviour
{
    [SerializeField] Image fillImage = null;
    [SerializeField] FloatReference currentHealth = null;
    [SerializeField] FloatReference maxHealth = null;

    private void Awake()
    {
        currentHealth.Value = maxHealth.Value;
    }

    public void HealthChanged()
    {
        Debug.Log("HealthBarHealth::HealthChanged currentHealth changed: " + currentHealth.Value);
        fillImage.fillAmount = currentHealth.Value / maxHealth.Value;
    }
}