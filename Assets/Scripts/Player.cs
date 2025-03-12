using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;
    private Vector2 _direction;

    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // captura inputs e algumas lógicas que não usem física
    private void Update()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //vector2 pega o eixo x e eixo y
    }

    // só utiliza lógicas com física
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + _direction * speed * Time.fixedDeltaTime);
    }
}
