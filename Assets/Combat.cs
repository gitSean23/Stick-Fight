using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField]
    // private Rigidbody2D rb;

    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
          Punch();
        }
    }

    void Punch()
    {
      // Play anim
      animator.SetTrigger("isPunching");

      // Detect enemies in range
      Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

      foreach(Collider2D enemy in hitEnemies)
      {
        Debug.Log("Stickman " + enemy.name + " hit");
      }


    }

    void OnDrawGizmosSelected()
    {
      if (attackPoint == null)
        return;
        
      Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
