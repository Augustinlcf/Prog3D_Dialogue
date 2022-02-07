using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeTextContent("Mon nouveau titre"));
    }

    private IEnumerator ChangeTextContent(string newContent)
    {
        yield return new WaitForSeconds(5f);
        textComponent.text = newContent;
    }
}
