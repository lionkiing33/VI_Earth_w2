using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public Joystick joystick;   //조이스틱 스크립트
    public float MoveSpeed = 3.0f;     //플레이어 이동속도

    public GameObject Map_Player, Player;

    Animator animator;

    string animationState = "AnimationState";
    Rigidbody2D rb2D;

    private Vector3 _moveVector, Player_current_location, Player_before_location; //플레이어 이동벡터, 플레이어의 현재 위치
    private Transform _transform;

    enum CharStates
    {
        walkEast = 1,
        walkSouth = 2,
        walkWest = 3,
        walkNorth = 4,
        idleSouth = 5
    }

    void Start()
    {
        _transform = transform;      //Transform 캐싱
        _moveVector = Vector3.zero;  //플레이어 이동벡터 초기화
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //터치패드 입력 받기
        HandleInput();
    }

    private void FixedUpdate()
    {

        Player_before_location = Player.transform.position;
        //플레이어 이동
        Move();
        if (_moveVector.x > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkEast);
        }
        else if (_moveVector.x < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkWest);
        }
        else if (_moveVector.y > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkNorth);
        }
        else if (_moveVector.y < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkSouth);
        }
        else
        {
            animator.SetInteger(animationState, (int)CharStates.idleSouth);
        }

    }

    public void HandleInput()
    {
        Player_current_location = Player.transform.position;

        _moveVector = PoolInput();
        //Vector3 current_pos = Player.transform.position;
        //Debug.Log(current_pos);
        //Debug.Log(_moveVector);
        //Debug.Log("현재의 위치 : " + Player_current_location);

        if (_moveVector.x + Player_current_location.x == Player_current_location.x)
        {
            Map_Player.transform.Translate(0, _moveVector.y / 900, 0);
        }
        else if (Player_current_location.y < -4.45f)
        {
            Map_Player.transform.Translate(0, 0, 0);
        }
        else if (Player_before_location.y == Player_current_location.y && Player_before_location.x == Player_current_location.x)
        {
            Debug.Log("멈춰라");
            Map_Player.transform.Translate(0, 0, 0);
        }
        else
        {
            Map_Player.transform.Translate(_moveVector.x / 1200, _moveVector.y / 900, 0);
        }
    }

    public Vector3 PoolInput()
    {
        float h = joystick.GetHorizontalValue();
        float v = joystick.GetVerticalValue();
        Vector3 moveDir = new Vector3(h, v, 0).normalized;

        return moveDir;
    }

    public void Move()
    {
        _transform.Translate(_moveVector * MoveSpeed * Time.deltaTime);
    }
}