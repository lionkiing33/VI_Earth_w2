using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public Joystick joystick;   //조이스틱 스크립트
    public float MoveSpeed = 3.0f;     //플레이어 이동속도

    Animator animator;

    string animationState = "AnimationState";
    Rigidbody2D rb2D;

    private Vector3 _moveVector; //플레이어 이동벡터
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
        _moveVector = PoolInput();
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