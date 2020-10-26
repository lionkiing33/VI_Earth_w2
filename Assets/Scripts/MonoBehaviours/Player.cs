using UnityEngine;

public class Player : Character
{
    //TaskBar 프리팹의 참조를 저장함
    public TaskBar taskBarPrefab;

    //Directory 프리팹의 참조를 저장함
    public Directory directoryPrefab;

    //인스턴스화한 TaskBar의 참조를 저장할 변수
    TaskBar taskBar;

    //인스턴스화한 Directory의 참조를 저장할 변수
    Directory directory;

    //충돌한 객체와의 이벤트
    void OnTriggerEnter2D(Collider2D collision)
    {
        //충돌한 객체의 태그이름이 "CanBePickedUp"일 경우 조건문 실행
        if(collision.gameObject.CompareTag("Interaction"))
        {
            //충돌 객체의 값을 InteractObject객체인 taskObject에 저장함
            InteractObject taskObject = collision.gameObject.GetComponent<Interaction>().interactObject;

            //저장된 taskObject에 값이 존재하는경우
            if(taskObject != null)
            {
                //해당 객체의 이미지 비활성화 유무 변수
                bool shouldDisappear = false;
                
                //해당 객체의 아이템타입에 따른 조건문
                switch(taskObject.objectType)
                {
                    //아이템이 COIN인 경우
                    case InteractObject.ObjectType.COIN:
                        //해당 객체의 수량값을 업무현황게이지 갱신함수에 전달한다
                        if (directory.ModifyQuest(taskObject))
                        {
                            //인벤토리 내 해당 객체를 추가
                            AdjustTaskPoints(taskObject.taskPoints);
                        }
                        //이미지 객체 비활성화 변수 선언
                        shouldDisappear = true;
                        break;

                    //아이템이 HEART인 경우
                    case InteractObject.ObjectType.HEART:
                        //해당 객체의 수량값을 업무현황게이지 갱신함수에 전달한다
                        if (directory.ModifyQuest(taskObject))
                        {
                            //인벤토리 내 해당 객체를 추가
                            AdjustTaskPoints(taskObject.taskPoints);
                        }
                        //이미지 객체 비활성화 변수 선언
                        shouldDisappear = true;
                        break;

                    //아이템타입이 식별되지 않은 경우
                    default:
                        break;
                }
                //해당 이미지객체를 비활성화 할지 판별
                if(shouldDisappear)
                {
                    //해당 객체의 이미지 비활성화
                    collision.gameObject.SetActive(false);
                }
            }
        }
    }

    //플레이어의 업무현황게이지 갱신함수
    public bool AdjustTaskPoints(int amount)
    {
        //현재 플레이어의 업무현황포인트가 최대치를 넘었는지 판별
        if(taskPoints.value < maxTaskPoints)
        {
            //현재 업무현황포인트에 추가된 업무수행포인트를 더하여 저장함
            taskPoints.value = taskPoints.value + amount;

            //갱신된 업무현황포인트를 console로 나타냄
            print("Adjusted taskPoints by: " + amount + ". New value: " + taskPoints.value);
            //갱신된것이 맞기 때문에 이후 이미지객체를 사라지게 하기위해 true반환
            return true;
        }
        //갱신 할수없기때문에 이미지 객체를 유지하기 위해서 false반환
        return false;
    }

    public void Start()
    {
        //Directory 프리팹을 인스턴스화하고 인스턴스화한 프리팹의 참조를 directory 변수에 저장함
        directory = Instantiate(directoryPrefab);

        //플레이어의 퀘스트 진행 게이지가 startingTaskPoints값으로 시작하게 taskPoints.value에 대입한다
        taskPoints.value = startingTaskPoints;

        //TaskBar 프리팹을 인스턴스화하고 인스턴스화한 프리팹의 참조를 taskBar 변수에 저장함
        taskBar = Instantiate(taskBarPrefab);

        taskBar.character = this;
    }
}