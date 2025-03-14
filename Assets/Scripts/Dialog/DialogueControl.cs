using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profileSprite;
    public TextMeshProUGUI speechText; //texto da fala
    public TextMeshProUGUI actorNameText;

    [Header("Settings")]
    public float typingSpeed;

    private bool isShowing;
    private int index;
    private string[] sentences;

    public static DialogueControl instance;

    // é chamado antes de todos os starts
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {

    }

    public void Speech(string[] texts)
    {
        if (!isShowing)
        {
            dialogueObj.SetActive(true);
            sentences = texts;
            StartCoroutine(TypeSentence());
            isShowing = true;
        }
    }
}
