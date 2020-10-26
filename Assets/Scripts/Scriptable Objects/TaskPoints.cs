using UnityEngine;

//생성 메뉴 안에 "TaskPoints"라는 하위 메뉴를 만들어 준다
//메뉴를 통해 스크립팅 가능한 오브젝트인 "TaskPoints"의 인스턴스를 쉽게 만들 수 있다
[CreateAssetMenu(menuName = "TaskPoints")]

//TaskPoints라는 퀘스트 진행 게이지를 스크립팅 가능한 오브젝트로 생성하고 플레이어와 공유하기 위한 스크립트
public class TaskPoints : ScriptableObject
{
    //게이지에 해당하는 meter 이미지 오브젝트의 채우기 양 속성에 float 값을 대입해야함
    public float value;
}