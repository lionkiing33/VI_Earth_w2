using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Game_Player : MonoBehaviour
{
    public int move_method;
    public GameObject MiniGames_Panel, Player, Exit_Button, joystick;
    public float speed;
    public Vector2 speed_vec;
    // Start is called before the first frame update
    void Start()
    {
        Exit_Button.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            Player.transform.position = new Vector3(-6.5f, -0.5f, 0);
            Debug.Log("닿았음!");
            MiniGames_Panel.SetActive(false);
            joystick.SetActive(true);
        }

        else if(collision.CompareTag("Enemy"))
        {
            Player.transform.position = new Vector3(-6.5f,-0.5f,0);
            Exit_Button.SetActive(true);
            //수정해야할점. 빨간 원에 부딪히면 파란색 네모(플레이어)가 재생성되어야한다.
        }
    }

    // Update is called once per frame
    void Update()//방향키를 누르는 대로 움직인다.
    {
        //수정해야할점. 플레이어가 움직일떄 해당 패널의 collider이외 외부의 collider까지 적용이된다.
        if (move_method == 0)
        {
            speed_vec = Vector2.zero;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                speed_vec.x += speed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                speed_vec.x -= speed;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                speed_vec.y += speed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                speed_vec.y -= speed;
            }
            transform.Translate(speed_vec);
        }

        else if(move_method == 1) //관성의 법칙을 적용하기 떄문에 움직일 때 부드러움이 추가된다.
        {
            speed_vec.x = Input.GetAxis("Horizontal") * speed;
            speed_vec.y = Input.GetAxis("Vertical") * speed;

            transform.Translate(speed_vec);
        }

        else if(move_method == 2)
        {
            speed_vec = Vector2.zero;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                speed_vec.x += speed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                speed_vec.x -= speed;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                speed_vec.y += speed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                speed_vec.y -= speed;
            }

            GetComponent<Rigidbody2D>().velocity = speed_vec;
        }
    }
}
