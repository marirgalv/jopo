using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int velocidade;
    public int vida;
    public int forcaPulo;
    private Rigidbody2D rb;
    public float moveH;
    public float moveV;
    public bool isJumping = false;
    private Vector3 posInicial;
     private Animator anim;
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //andar
        moveH = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, 0);

    }

    void Update()
    {
  

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetLayerWeight(1,1);
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetLayerWeight(1,1);
            sprite.flipX = false;
        }
        else
        {
             anim.SetLayerWeight(1,0);

        }

       
      
          //pular
        if(Input.GetKey(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(transform.up * forcaPulo,ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Chão"))
        {
            isJumping = false;
        }
         if(other.gameObject.CompareTag("void"))
        {
            Destroy(gameObject);
        }
    }

}