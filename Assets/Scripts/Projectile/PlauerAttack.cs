using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
        [SerializeField] private float attackCooldown;
    
        [SerializeField] private transform firePoint;
  
        [SerializeField] private GameObject [] fireballs;

        private Animator anim;

        private PLayerMovement PLayerMovement;
        privatre flaot cooldownTime = Math.Infinity;

        private void Awake()
        {
            anim = get GetComponent<Animator>();
            PLayerMovement = GetComponent<PLayerMovement>()
        }


        private void Update()
        {
            if(Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canatttack())

            cooldownTimer += colldownTimer.deltaTime;
        }

        private void Attack()
        {
            anim.SetTrigger("attack");
            cooldownTimer = 0;

            fireballs[0].transform.position = firePoint.position
            fireballs[0].GetComponent<Projectitile>().SetDirection(Mathf.Sign(transform.localScale.x)); 
       }
}
