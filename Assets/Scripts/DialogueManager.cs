using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject buttonStart;
    [SerializeField] private GameObject buttonNext;
    [SerializeField] private GameObject buttonPrevious;
    [SerializeField] private DialogueSo dialogueSo;
    [SerializeField] private TextMeshProUGUI textBox;
    [SerializeField] private TextMeshProUGUI textBoxSuivant;
    public bool isOnDialogue;
    public int currentDialogue=0;

    IEnumerator Writing(string sentence)
    {
        textBox.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            textBox.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }
    public void StartDialogue()
    {
        if (isOnDialogue == false)
        {
            buttonStart.SetActive(false);
            buttonNext.SetActive(true);
            buttonPrevious.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(Writing(dialogueSo.dialogue[currentDialogue]));
            isOnDialogue = true; 
            textBoxSuivant.text = ">>>";
            
        }
        
    }

    public void NextLine()
    {
        if (isOnDialogue && currentDialogue < dialogueSo.dialogue.Length - 2)
        {
            currentDialogue++;
            StopAllCoroutines();
            StartCoroutine(Writing(dialogueSo.dialogue[currentDialogue]));
        }
        else if (isOnDialogue && currentDialogue == dialogueSo.dialogue.Length - 2)
        {
            currentDialogue++;
            StopAllCoroutines();
            StartCoroutine(Writing(dialogueSo.dialogue[currentDialogue]));
            textBoxSuivant.text = "Leave";
        }
        else if (isOnDialogue && currentDialogue == dialogueSo.dialogue.Length - 1)
        {
            StopAllCoroutines();
            StartCoroutine(Writing("Bye !"));
            buttonNext.SetActive(false);
            buttonPrevious.SetActive(false);
            buttonStart.SetActive(true);
            buttonStart.GetComponentInChildren<TextMeshProUGUI>().text = "Start";
            isOnDialogue = false;
            currentDialogue = 0;
        }
    }

    public void PreviousLine()
    {
        if (isOnDialogue && currentDialogue == dialogueSo.dialogue.Length - 1)
        {
            textBoxSuivant.text = ">>>";
            currentDialogue--;
            StopAllCoroutines();
            StartCoroutine(Writing(dialogueSo.dialogue[currentDialogue]));
        }
        else if (isOnDialogue && currentDialogue >=1 && currentDialogue < dialogueSo.dialogue.Length - 1)
        {
            currentDialogue--;
            StopAllCoroutines();
            StartCoroutine(Writing(dialogueSo.dialogue[currentDialogue]));
        }
    }
}
