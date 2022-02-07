using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManualTextChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;

    public void ChangeText(string content)
    {
        textComponent.text = content;
    }
 
}
