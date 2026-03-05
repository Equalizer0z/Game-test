using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private float jumpPower;

    [SerializeField] private LayerMask groundlayer;

    [SerializeField] private LayerMask wallLayer;

private Rigidbody2D body;

private BoxCollider2D BoxCollider;

private float wallJumpCooldown;

private Animator anim;

private float horizontalInput;

 private void Awake()
 {
   body = GetComponent<Rigidbody2D>();
   anim = GetComponent<Animator>();
   BoxCollider = GetComponent<BoxCollider2D>();
 }

 private void Update()
 {
    float horizontalInput = Input.GetAxis("Horizontal");
    body.linearVelocity = new Vector2(horizontalInput * speed, body. linearVelocity.y);

    if(horizontalInput > 0.01f)
        transform.localScale = Vector3.one;
    else if(horizontalInput > -0.01f)
        transform.localScale = new Vector3(-1,1,1);



anim.SetBool("run", horizontalInput != 0);
anim.SetBool("grounded", grounded);

if(Input.GetKey(KeyCode.Space))
body.linearVelocity = new Vector2(body.linearVelocity.x, speed);

anim.SetBool("run", horizontalInput != 0);
anim.SetBool("grounded", grounded);

    if(wallJumpCooldown > 0.2f)
    {
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if(onWall() && !isGrounded())
        {
            body.gravityScale = 0
            body.velocity = Vector2.zero;
        }
        else
            wallJumpCooldown += Time.deltaTime;

        if(Input.GetKey(Keycode.Space))
        Jump();


}
else wallJumpCooldown += Time.delta;
 }

private void Jump()
{
    if(isGrounded())
    {

    body.linearVelocity = new Vector2(bod.linearVelocity.x, jumpPower);
anim.SetTrigger("jump");
    }
    else if(onWall() && !isGrounded())
    {
        if(horizontalInput == 0)
        {
            body.velocity = new Vector2(-Mathf.Sign(transform.local.localScale.x) * 10, 0)
            transform.localScale = new Vector3(=Mathf.Sign(transform,localScale.x), transform.localScale.y transform.localScale.z);
        }

        else
            body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6)

            wallJumpCooldown = 0;
    }
}
private void OnCollisionEnter2D(Collision2D collision)
{
}

private bool isGrounded()
{
    RaycastHit2D raycastHit = Physicals2D.BoxcCast(BoxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2.down, 0.1f, groundLayer);
}
private bool()
{
    RaycastHit2D raycastHit = Physicals2D.BoxcCast(BoxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down(transform.localScale.x 0), 0.1f, wallLayer);
    return raycastHit.collider != null;
}
}