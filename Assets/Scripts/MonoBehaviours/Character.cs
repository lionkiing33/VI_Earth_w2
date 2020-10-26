using UnityEngine;

//Player 클래스와 Enemy 클래스가 공통적으로 상속할 공용 클래스
//해당 클래스에 모든 캐릭터가 공통적으로 지녀야 할 기능과 속성을 담을 예정

//abstract 한정자를 사용해서 인스턴스화할 수 없고 하위 클래스에서 상속해야 하는 클래스임을 나타냄
public abstract class Character : MonoBehaviour
{
    //플레이어의 퀘스트 진행 게이지 오브젝트
    public TaskPoints taskPoints;

    //플레이어의 최대 퀘스트 진행 게이지 값(100)
    public float maxTaskPoints;

    //플레이어의 최초 퀘스트 진행 게이지 값(0)
    public float startingTaskPoints;
}
