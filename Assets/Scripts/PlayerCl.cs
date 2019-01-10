using UnityEngine;
using System.Collections;

public class PlayerCl : MonoBehaviour
{
    private Animator anim;
    public float speed = 4f;
    public bool isMove = false;
    public Transform sword;
    public float sword_radius;
    public float timer = 1;
    public float PlayerHP;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (PlayerHP <= 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Attack", true);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        else
        {
            anim.SetBool("Attack", false);
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX > 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", true);
        }
        if (moveX < 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
        }
        if (moveY < 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", true);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveY > 0)
        {
            anim.SetBool("Up", true);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX < 0 && moveY < 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", true);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX > 0 && moveY < 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", true);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX < 0 && moveY > 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", true);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX > 0 && moveY > 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", true);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX == 0 && moveY == 0)
        {
            anim.SetBool("Up", false);
            anim.SetBool("Down", false);
            anim.SetBool("UpLeft", false);
            anim.SetBool("UpRight", false);
            anim.SetBool("DownLeft", false);
            anim.SetBool("DownRight", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
        if (moveX != 0 || moveY != 0)
        {
            isMove = true;
        }
        else
        {
            isMove = false;
        }
        transform.Translate(new Vector3(moveX, moveY, 0));

        if (Input.GetKey(KeyCode.Space))
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Fight_Melee.Action(sword.position, sword_radius, 8, 12, false);
                timer = 1;
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Item")
        {
            PlayerHP = 100;
        }
    }
}