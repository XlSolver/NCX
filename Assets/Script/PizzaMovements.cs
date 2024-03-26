using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Movements : MonoBehaviour
{
    public Animator anim; //Animazione
    public bool isPizzaAlive = true;
    public float jumpVelocity;
    public BoxCollider2D boxCollider2d;
    public Rigidbody2D rigidbody2d;

    [SerializeField] private LayerMask Ground;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //recupera l'animazione
        if (anim == null)
        {
            Debug.LogError("Animator component not found on character!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Salto
        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private bool isGrounded()
    {
        float extraHeightText = 0.1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, Ground);

        Color rayColor;
        if (raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(boxCollider2d.bounds.center + new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, boxCollider2d.bounds.extents.y + extraHeightText), Vector2.right * (boxCollider2d.bounds.extents.x * 2f), rayColor);

        Debug.Log(raycastHit.collider);
        return raycastHit.collider != null;
    }
}
