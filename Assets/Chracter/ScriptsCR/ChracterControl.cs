using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChracterControl : MonoBehaviour
{
    [SerializeField] float hareketHizi;
    [SerializeField] float hiz;
    float hor;
    Rigidbody rb;
    public Animator animKing;
    public float Healt;
    public Joystick joystick;
    public TextMeshProUGUI hasarText;


    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        Healt = 100;
        hasarText.text ="HASAR"+ Healt.ToString();
    }

    public void Update()
    {
        MovePlayer();   
    }

    public void MovePlayer()
    {
        if (joystick.Horizontal != 0f || joystick.Vertical != 0f)
        {
            if (rb.velocity.y >= -2.5f && rb.velocity.y <= 2f)
            {
                var movePos = transform.forward;
                movePos.y = -0.3f;
                rb.velocity = movePos * hareketHizi;
                animKing.SetBool("Run", true);
                var lookPos = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 15);
            }

        }
        else
        {
            animKing.SetBool("Run", false);
            var zeroPos = Vector3.zero;
            zeroPos.y = -0.3f;

        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            animKing.SetBool("kingGirdi", true);
            HasarAl();


        }
        if (other.gameObject.CompareTag("ObstacleEnemy"))
        {

            Debug.Log("HasarAldı");
            HasarAl();
        }

    }


    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            animKing.SetBool("kingGirdi", false);


        }


    }

    public void HasarAl()
    {
        Healt -= Random.Range(5, 15);
        hasarText.text = "HASAR" + Healt.ToString();
    }

}
