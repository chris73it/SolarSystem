using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUpdate : MonoBehaviour
{
    [SerializeField] Image fillImage = null;
    [SerializeField] FloatReference currentHealth = null;
    [SerializeField] FloatReference maxHealth = null;

    private void Update()
    {
        fillImage.fillAmount = currentHealth.Value / maxHealth.Value;
    }
}
