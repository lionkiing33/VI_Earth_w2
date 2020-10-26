using UnityEngine;
using UnityEngine.UI;

public class TaskBar : MonoBehaviour
{
    //퀘스트 진행 게이지
    public TaskPoints taskPoints;

    //인스펙터에서 감추어서 속성을 설정
    [HideInInspector]

    //플레이어 객체
    public Player character;
    //퀘스트 진행 미터 이미지 객체
    public Image meterImage;
    //최대 퀘스트 진행 게이지 변수
    float maxTaskPoints;

    void Start()
    {
        //플레이어 객체의 최대 퀘스트 진행 게이지 값을 불러와서 저장
        maxTaskPoints = character.maxTaskPoints;
    }

    void Update()
    {
        //플레이어 객체가 존재하는 상태
        if(character != null)
        {
            //퀘스트 진행 미터 이미지 객체의 비율은 최대 퀘스트 진행 게이지값에 플레이어 객체의 현재 퀘스트 진행 게이지값으로 나누어준다.
            meterImage.fillAmount = taskPoints.value / maxTaskPoints;
        }
    }
}