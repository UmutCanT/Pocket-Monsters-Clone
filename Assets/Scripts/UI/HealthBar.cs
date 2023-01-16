using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    Slider slider;
    TextMeshProUGUI healthText;
    readonly string hpTextTemp = "{0}/ {1}";

    private void Awake()
    {
        slider = GetComponent<Slider>();
        healthText =  GetComponentInChildren<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInitialHP(int currentHP, int maxHP)
    {
        slider.value = (float)currentHP/maxHP;
        if(healthText!= null )
        {
            healthText.text = string.Format(hpTextTemp, currentHP, maxHP);
        }
    }

    public void SetCurrentHP()
    {
        if (healthText != null)
        {
            healthText.text = string.Format(hpTextTemp, slider.value, slider.maxValue);
        }
    }
}
