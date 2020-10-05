# VI_Earth_w2
VI Earth의 4주차 프로젝트 진행 사항

![KakaoTalk_20200928_143005466](https://user-images.githubusercontent.com/54584364/94410075-e784a080-01b1-11eb-85ca-0c5053c17588.jpg)

[실행 영상](https://youtu.be/y_aLr3tahBc)

1. CinemachineVirtualCamera
- CinemachineVirtualCamera은 기준점을 정하고 해당 기준점에 따라 카메라 영역, 기준점 영역, 카메라 밖의 영역을 각각 따로 설정할수있으며
기준점 영역을 Dead Zone이라 부르며 기준점이 움직이면서 Dead Zone을 벗어나면 카메라가 따라가며 Dead Zone영역 안으로 유지하려는 성질을 갖는다
카메라영역을 Soft Zone이라 부르며 실제 제작된 타일맵 내 사용자에게 보여지는 화면이므로 스케일을 넓혀 광대한 범위를 시각적으로 보여주거나 축소하여 좁은 영역만을 보여줄수있다.

2. Grid(Ground/Trees and Rocks/Water)
- Ground레이어는 현재 화면에서 보여지는 풀밭과 논밭으로 구성이되어있으며 Player가 이동하는데 제약을 주지않는다
- Trees and Rocks 레이어는 Ground레이어 위에 추가된 오브젝트임으로 Player이동에 제약을 주는 Rigidbody2D와 Tilemap Collider2D를 설정하였다.
-Water 레이어는 Ground레이어 외각 부분의 바다를 나타내고 Player가 해당지역을 이동할수없게 Rigidbody2D와 Tilemap Collider2D를 설정하였다.

3. Coin Object/Heart Object
- Coin 오브젝트는 Player가 Coin에 다가가면 타일맵에 Coin이 사라지며 Inventory에 Coin이 나타나게 됩니다. Player가 직접 소지하게되는 아이템입니다
- 해당 Coin 오브젝트를 사용자의 임무로 변형하여 기존의 Coin을 먹으면 Inventory 슬롯에 증가하는것이 아닌 Inventory 슬롯에 다수의 임무를 지정해두고
임무를 클리어할때마다 오브젝트가 줄어드는 형식으로 제작할 예정입니다.

- Heart 오브젝트는 Player가 Heart에 다가가면 타일맵에 Heart가 사라지며 HealthBar에 HP가 10증가하게됩니다. Player의 상태를 변화시키는 아이템입니다.
- 해당 Heart 오브젝트를 플레이어의 임무 오브젝트로 변형하여 Heart오브젝트에 다가가면 HealthBar에 10 증가하는것이 아닌 Heart오브젝트에 다가가서 상호작용 버튼을 눌러
임무를 완료하면 HealthBar가 채워지는 형식으로 제작할 예정입니다.

4. Inventory/HealthBar
- Inventory는 부모 클래스인 Inventory와 자식 클래스인 Slot으로 구성되어있어 Inventory안에 5개의 Slot이 구성되어있고 Slot 내부에는 아이템의 이미지를 나타내는 Tray와 해당 아이템의 수량을 나타내는 QtyText가 구성되어있습니다.
- 해당 Inventory를 플레이어의 임무 표로 변형하여 비어있는 Inventory로 시작하여 아이템을 얻고 채워가는 형식이 아닌 임무(Coin Object)가 채워져있는 상태에서 임무를 완료할때마다
해당 임무의 갯수 및 이미지를 없애는 형식으로 제작할 예정입니다.

- HealthBar는 HealthBar는 큰 막대기 바 안에 플레이어의 체력상태를 비율로 나타내어주는 막대기 바와 밑에 숫자와 글로 표현된 Text로 구성되어있으며 플레이어의 상태를 시각적으로 표현을 해줍니다.
- 해당 HealthBar를 팀의 임무 현황 상태로 변환하여 플레이어 자신 뿐만 아니라 다른 플레이어의 임무까지 합산하여 임무를 할때마다 HealthBar에 일정 수치가 올라가게 표현을 할 예정입니다

5. Player Object
- 저번 주차 Player Object에는 타일맵 이동, 지정된 구역이외 이동 제한, Trees and Rocks오브젝트 부딪힘 설정, Coin및Heart Object 상호작용 기능들을 설정하였으며 위에 설명드렸던 Heart/Coin Object의 개선안에 따른 C#스크립트를 수정하여 제작할예정입니다.
