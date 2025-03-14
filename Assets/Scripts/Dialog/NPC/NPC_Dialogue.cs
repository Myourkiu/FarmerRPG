using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{
    public float dialogueRange;
    public LayerMask playerLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ShowDialogue();
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer); // a partir de que ponto vai desenhar a esfera - raio - camada especifica

        if (hit != null)
        {
            Debug.Log("player na area de colisão");
        }
        else
        {

        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }
}
