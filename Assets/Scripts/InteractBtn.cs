using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class InteractBtn : MonoBehaviour
{
    //플레이어 게임오브젝트
    public GameObject player;
    //미니게임패널 게임오브젝트
    public GameObject Street_lamp_panel;
    //조이스틱 게임오브젝트
    public GameObject visual_joystick;

    public const int numCoins = 3;
    public const int numHearts = 3;

    public GameObject[] coins = new GameObject[numCoins];
    public GameObject[] hearts = new GameObject[numHearts];

    List<GameObject> missions = new List<GameObject>();
    double[] distances;
    double min;
    GameObject nearbyObject;

    //상호작용 게임오브젝트 이미지 객체
    SpriteRenderer objImage;
    SpriteOutline objectBorder;

    //버튼 배경 게임오브젝트 이미지 객체
    Image btnImage;
    Button interactButton;

    //컬러 객체
    Color normal = new Color(255, 255, 255, 255);
    Color yellow = new Color(255, 255, 0, 255);
    Color transparent = new Color(255, 255, 255, 0.5f);

    // Start is called before the first frame update
    void Start()
    {
        Street_lamp_panel.SetActive(false);
        for (int i=0;i<numCoins;i++)
        {
            missions.Add(coins[i]);
        }
        for (int i = 0; i < numHearts; i++)
        {
            missions.Add(hearts[i]);
        }
        //지속적으로 UI 변경을 해야합니다.
        btnImage = this.GetComponent<Image>();
        btnImage.color = transparent;
        interactButton = this.GetComponent<Button>();
        interactButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posPlayer = player.gameObject.transform.position;
        btwPlayerAndObjects(posPlayer, missions);
    }

    //플레이어와 상호작용 오브젝트 사이의 거리 계산하는 메소드
    public double calcDistance(Vector3 posPlayer, Vector3 posObject)
    {
        double btwX = (posPlayer.x - posObject.x) * (posPlayer.x - posObject.x);
        double btwY = (posPlayer.y - posObject.y) * (posPlayer.y - posObject.y);
        double distance = Math.Sqrt(btwX + btwY);
        return distance;
    }

    //상호작용 객체(배열)들과 플레이어 객체 사이의 거리에 따른 UI변경 메소드
    public void btwPlayerAndObjects(Vector3 posPlayer, List<GameObject> missions)
    {
        Vector3 posObject;
        min = 100.0;
        distances = new double[numCoins + numHearts];
        for (int i=0;i<missions.Count;i++)
        {
            posObject = missions[i].gameObject.transform.position;
            double distance = calcDistance(posPlayer, posObject);
            distances[i] = distance;

            if (distances[i] > 4.0)
            {
                //오브젝트 태두리 설정
                objectBorder = missions[i].GetComponent<SpriteOutline>();
                objectBorder.enabled = false;
                //오브젝트 컬러 설정
                objImage = missions[i].gameObject.GetComponent<SpriteRenderer>();
                objImage.color = normal;
            }
            else if (distances[i] <= 4.0 && distances[i] > 2.0)
            {
                //오브젝트 태두리 설정
                objectBorder = missions[i].GetComponent<SpriteOutline>();
                objectBorder.enabled = true;
                //오브젝트 컬러 설정
                objImage = missions[i].gameObject.GetComponent<SpriteRenderer>();
                objImage.color = normal;
            }
            else
            {
                //오브젝트 태두리 설정
                objectBorder = missions[i].GetComponent<SpriteOutline>();
                objectBorder.enabled = true;
                //오브젝트 컬러 설정
                objImage = missions[i].gameObject.GetComponent<SpriteRenderer>();
                objImage.color = yellow;
            }

            if (min > distances[i])
            {
                min = distances[i];
                nearbyObject = missions[i];
            }
            if (i == missions.Count - 1)
            {
                if (min <= 2.0)
                {
                    btnImage.color = normal;
                    interactButton.interactable = true;
                }
                else
                {
                    btnImage.color = transparent;
                    interactButton.interactable = false;
                }
            }
        }
    }

    /*
    //상호작용 객체(배열)들과 플레이어 객체 사이의 거리에 따른 UI변경 메소드
    public bool btwPlayerAndObject(Vector3 posPlayer, GameObject obj)
    {
        Vector3 posObject = obj.gameObject.transform.position;
        float distance = calcDistance(posPlayer, posObject);

        if (distance > 4.0)
        {
            //오브젝트 태두리 설정
            objectBorder = obj.GetComponent<SpriteOutline>();
            objectBorder.enabled = false;
            //오브젝트 컬러 설정
            objImage = obj.gameObject.GetComponent<SpriteRenderer>();
            objImage.color = normal;
        }
        else if (distance <= 4.0 && distance > 2.0)
        {
            //오브젝트 태두리 설정
            objectBorder = obj.GetComponent<SpriteOutline>();
            objectBorder.enabled = true;
            //오브젝트 컬러 설정
            objImage = obj.gameObject.GetComponent<SpriteRenderer>();
            objImage.color = normal;
        }
        else
        {
            //오브젝트 태두리 설정
            objectBorder = obj.GetComponent<SpriteOutline>();
            objectBorder.enabled = true;
            //오브젝트 컬러 설정
            objImage = obj.gameObject.GetComponent<SpriteRenderer>();
            objImage.color = yellow;
            return true;
        }
        return false;
    }
    */
    /*
    public void setInteractButton(GameObject[] objects)
    {
        Vector3 posPlayer = player.gameObject.transform.position;
        for (int i = 0; i < objects.Length; i++)
        {
            //지속적으로 UI 변경을 해야합니다.
            if (btwPlayerAndObject(posPlayer, objects[i]))
            {
                if(interactButton.interactable == false)
                {
                    //버튼 투명도 설정
                    btnImage.color = normal;
                    interactButton.interactable = true;
                }
            }
            else
            {
                if (interactButton.interactable == true)
                {
                    //버튼 투명도 설정
                    btnImage.color = transparent;
                    interactButton.interactable = false;
                }
            }
        }
    }
    */

    public void OnClicked()
    {
        if (Street_lamp_panel.activeSelf == false)
        {
            Street_lamp_panel.SetActive(true);
            visual_joystick.SetActive(false);
        }
        else
        {
            Street_lamp_panel.SetActive(false);
            visual_joystick.SetActive(true);
        }
    }
}