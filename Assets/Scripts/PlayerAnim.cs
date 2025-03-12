using UnityEngine;

public class PlayerAnim : MonoBehaviour
{

    private Player player;
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        onMove();
        onRun();
    }

    #region Movement

    void onMove()
    {
        if (player.direction.sqrMagnitude > 0)
            anim.SetInteger("transition", 1);
        else
            anim.SetInteger("transition", 0);

        if (player.direction.x > 0)
            transform.eulerAngles = new Vector2(0, 0);

        if (player.direction.x < 0)
            transform.eulerAngles = new Vector2(0, 180);
    }

    void onRun()
    {
        if (player.isRunning)
            anim.SetInteger("transition", 2);
    }

    #endregion
}
