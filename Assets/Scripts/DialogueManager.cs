using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private DialogueSo dialogueSo;
    [SerializeField] private TextMeshProUGUI textBox;
    public bool isOnDialogue;
    public int currentDialogue=0;

    public void StartDialogue()
    {
        textBox.text = dialogueSo.dialogue[currentDialogue];
        isOnDialogue = true;
    }

    public void NextLine()
    {
        if (isOnDialogue && currentDialogue != dialogueSo.dialogue.Length - 1)
        {
            currentDialogue++;
            textBox.text = dialogueSo.dialogue[currentDialogue];
        }
        else if (isOnDialogue && currentDialogue == dialogueSo.dialogue.Length - 1)
        {
            isOnDialogue = false;
            currentDialogue = 0;
            textBox.text = "";
        }
    }
}
