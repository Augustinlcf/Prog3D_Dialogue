using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    [SerializeField] private WeaponObject weapon;

    private void Awake()
    {
        textComponent.text = $"Damage : {weapon.damage} \n Range : {weapon.range} \n Rate Of Fire : {weapon.rateOfFire}";
    }
}
