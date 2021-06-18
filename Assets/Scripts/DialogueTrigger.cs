using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DialogueTrigger : MonoBehaviour{

    public NewDialogue _dialogue;
    private DialogueManager _dialogueManager;

    void Start()
    {
        _dialogueManager = FindObjectOfType<DialogueManager>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Character")
       {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (_dialogueManager.dialogueActive == false)
                {
                    FindObjectOfType<DialogueManager>().StartDialogue(_dialogue);
                    _dialogueManager.dialogueActive = true;
                    _dialogueManager.dbox.SetActive(true);
                }
            }
        }
    }
}
