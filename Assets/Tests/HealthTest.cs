using ScriptableObjectArchitecture;
using UnityEngine;

public class HealthTest : MonoBehaviour
{
    [SerializeField] float currentHealthInput;
    [SerializeField] FloatReference currentHealth = null;
    [SerializeField] FloatReference maxHealth = null;

    void Start()
    {
        currentHealthInput = maxHealth.Value;
    }

    void Update()
    {
        if (currentHealth.Value != currentHealthInput)
        {
            currentHealth.Value = currentHealthInput;
        }
    }
}
