using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{
    public float dialogueRange;
    public LayerMask playerLayer;

    public DialogueSettings dialogue;
    bool playerHit;

    private List<string> sentences = new List<string>();


    private void Start()
    {
        GetNpcInfo();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerHit)
        {
            DialogueControl.instance.Speech(sentences.ToArray());
        }
    }

    void FixedUpdate()
    {
        ShowDialogue();
    }

    void GetNpcInfo()
    {
        for (int i = 0; i < dialogue.dialogues.Count; i++)
        {
            sentences.Add(dialogue.dialogues[i].sentence.portuguese);
        }
    }


    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer); // a partir de que ponto vai desenhar a esfera - raio - camada especifica

        if (hit != null)
        {
            playerHit = true;
        }
        else
        {
            playerHit = false;
            DialogueControl.instance.dialogueObj.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }
}
