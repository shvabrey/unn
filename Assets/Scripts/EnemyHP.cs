using UnityEngine;
using System.Collections;

public class EnemyHP : MonoBehaviour
{
    public float HP = 100;
    public Transform EnemyAttack;
    public float Attack_radius;
    public float timer = 3;
    private float Damage = 35;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Damage = 0;
        }
        else
        {
            Damage = 35;
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Fight_Melee_Enemy.Action(EnemyAttack.position, Attack_radius, 9, Damage, false);
            timer = 3;
        }
    }
}
