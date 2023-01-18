using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField]Slider slider;
    [SerializeField]TextMeshProUGUI healthText;
    readonly string hpTextTemp = "{0}/ {1}";

    private void Awake()
    {                
    }

    private void Start()
    {
        
    }

    public void SetInitialHP(int currentHP, int maxHP)
    {
        slider.maxValue = maxHP;
        slider.value = currentHP;

        if(healthText!= null )
        {
            healthText.text = string.Format(hpTextTemp, currentHP, maxHP);
        }
    }

    //later to-do OnHealthChange
    public void SetCurrentHP()
    {
        if (healthText != null)
        {
            healthText.text = string.Format(hpTextTemp, slider.value, slider.maxValue);
        }
    }

    public float CurrentValue() => slider.value;
    public float MaxHPValue() => slider.maxValue;
    public string HpText() => healthText.text;

}
