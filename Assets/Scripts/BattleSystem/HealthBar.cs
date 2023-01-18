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

    public void HealthBarInitializer(Pokemon pokemon)
    {
        slider.maxValue = pokemon.MaxHP;
        slider.value = pokemon.CurrentHP;

        if(healthText!= null )
        {
            healthText.text = string.Format(hpTextTemp, pokemon.CurrentHP, pokemon.MaxHP);
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

    //Test
    public float CurrentValue() => slider.value;
    public float MaxHPValue() => slider.maxValue;
    public string HpText() => healthText.text;

}
