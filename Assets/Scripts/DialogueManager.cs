using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    private Queue<string> _sentences;
    public Text _HeadingText;
    public Text _DialogueText;
    public bool dialogueActive;
    public GameObject dbox;

    private void Start()
    {
        _sentences = new Queue<string>();
    }

    public void StartDialogue(NewDialogue dialogue)
    {
        _HeadingText.text = dialogue._convoName;
        _sentences.Clear();

        foreach (string sentence in dialogue._sentences)
        {
            _sentences.Enqueue(sentence);
        }
        DisplayNextSentance();
    }

    public void DisplayNextSentance()
    {
        if (_sentences.Count ==0)
        {
            EndDialogue();
            return;
        }
            string sentence = _sentences.Dequeue();
        // _DialogueText.text = sentence;
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        _DialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            _DialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        dbox.SetActive(false);
    }
}
