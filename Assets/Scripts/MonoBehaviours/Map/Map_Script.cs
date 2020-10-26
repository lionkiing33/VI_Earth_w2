using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Map_Script : MonoBehaviour
{
    public GameObject cube, Player, Map_Player;
    public Vector3 pos;

    void Start()
    {
        cube.SetActive(false);
        pos = this.Player.transform.position;
        Debug.Log(pos);
        Map_Player.transform.Translate(0,0,0);
    }

    public void Update()
    {
    }

    public void Map_Button_OnMouseDown()
    {
        if (cube.activeSelf == false)
        {
            Debug.Log("아무말1");
            cube.SetActive(true);
        }
        else if (cube.activeSelf == true)
        {
            Debug.Log("아무말2");
            cube.SetActive(false);
        }
    }
    /*
    public void OnMouseDown()
    {
        if (cube.activeSelf == false)
        {
            Debug.Log("아무말1");
            cube.SetActive(true);
            exit_button.SetActive(true);
            visual_joystick.SetActive(false);
        }
        else
        {
            Debug.Log("아무말2");
            cube.SetActive(false);
            visual_joystick.SetActive(true);
        }
    }
    /*private void touch_enemy()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            Destroy(gameObject);
        }
    }*/


}
