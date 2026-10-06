using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;


    public Rigidbody2D rb2d;
    private Animator anim;
    private float _movement;
    private SpriteRenderer sprt;
    [SerializeField] private Vector2 _boxOffset;
    [SerializeField] private Vector2 _boxSize;
    [SerializeField] private LayerMask _boxLayer;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sprt = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.linearVelocityX = _movement;

        anim.SetFloat("Speed", Mathf.Abs(_movement) / 10);

     
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
        
        if (_movement < 0)
            sprt.flipX = true;
        else if (_movement > 0)
            sprt.flipX = false;
    }

 
    public void Jump(InputAction.CallbackContext ctx)
    {

        if (ctx.canceled || !IsGrounded())
            return;

        {


            rb2d.linearVelocityY = jumpHeight;
            anim.SetTrigger("Jump");
        }
    }
    public void Attack(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 1)
        {
            anim.SetTrigger("Attack");
        }
    }
        private bool IsGrounded()
        {
        //Check for ground
        RaycastHit2D hit = Physics2D.BoxCast(transform.position + (Vector3)_boxOffset, _boxSize, 0, Vector2.zero, 0, _boxLayer);
        

        return hit;
        }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetBool("IsGrounded", true);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        anim.SetBool("IsGrounded", false);
    }
}

