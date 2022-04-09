/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    Queue<string> sentences;
    Dialogue text;
    [SerializeField] TextMeshProUGUI screenText;
    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Estás hablando con" + dialogue.name);
    }

    public void ActivateBox(Dialogue objectText)
    {
        text = objectText;
    }

    public void ActivateText()
    {
        sentences.Clear();
        foreach(string saveText in text.arrayText)
        {
            sentences.Enqueue(saveText);
        }
    }
}
*/
