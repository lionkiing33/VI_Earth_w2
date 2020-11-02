# VI_Earth_w2

VI Earth의 9주차 프로젝트 진행 사항

![KakaoTalk_20201102_193431859](https://user-images.githubusercontent.com/54584364/97858559-ab110b00-1d42-11eb-8a97-f0ac3fcdb791.jpg)

![KakaoTalk_20201102_193426572](https://user-images.githubusercontent.com/54584364/97858602-ba905400-1d42-11eb-9e78-6fc73b620ffe.jpg)

![KakaoTalk_20201102_193426572_02](https://user-images.githubusercontent.com/54584364/97858630-c845d980-1d42-11eb-877b-2977ccf84217.jpg)

![KakaoTalk_20201102_193426572_01](https://user-images.githubusercontent.com/54584364/97858663-d3006e80-1d42-11eb-9fd0-0a0cdc221471.jpg)

[실행 영상](https://youtu.be/BPOsaszNyBs)

미니맵 패널 수정
- 기존의 미니맵 패널에는 미니맵 내 플레이어의 위치를 알려주는 오브젝트가 미니맵으로 지정한 크기를 벗어나는 문제가 있었습니다. 이를 해결하기 위해 미니맵 패널 내 경계선을 만들고 경계선에 box collider(박스 콜라이더)를 설정하여 충돌되어 지나갈수없게 구현하였습니다.

미니 게임 패널 내 미니게임 완료시 일과표 및 미션진행게이지 업데이트
- 저번주차에 미니게임을 완료하여도 일과표 및 미션 진행 게이지가 업데이트 되지 않는 문제점이 있었습니다. 이를 해결하기 위해 플레이어와 가장 가까운 거리에 위치한 미션오브젝트를 미니게임패널 스크립트에 전달하였고 해당 미션오브젝트 내 미션에 대한 정보를 가진 속성을 따로 추출하여 일과표와 미션진행게이지에 정보를 전달하여 업데이트를 구현하였습니다. 추가적으로 해당 미니게임은 하나의 미션오브젝트에 해당하기 때문에 미니게임의 미션과 일치하지 않는 오브젝트는 미니게임을 활성화 시키지 않았습니다.


------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

VI Earth의 8주차 프로젝트 진행 사항

![KakaoTalk_20201026_190214463](https://user-images.githubusercontent.com/54584364/97159289-f9139500-17bd-11eb-924c-fa3693f92459.jpg)

[실행 영상](https://youtu.be/GmK19T4plcA)

플레이어와 미션 오브젝트 사이 거리에 따른 UI변경
- 저번주차에 플레이어가 미션 수행이 가능한 오브젝트에 접근할때 일정 거리에 따른 UI변화를 주어 플레이어에게 미션이 가능한 오브젝트인지 아닌지를 쉽게 확인할수있게끔 보여주었습니다.
- 요번주차에는 플레이어가 미션 오브젝트 내 미션을 수행하기 위한 버튼이 오브젝트와 가까이 있을경우만 버튼이 활성화되고 버튼이미지의 투명도를 낮추고 근처에 오브젝트가 없으면 버튼을 비활성화하고 버튼이미지의 투명도를 높혔습니다.

미션오브젝트 근처에서 미션 수행 버튼 클릭시 이벤트
- 플레이어가 미션 오브젝트에 접근하여 미션 수행 버튼을 클릭하면 화면에 미션패널이 활성화되고 해당 패널의 미니게임을 플레이하고 미니게임을 완료하면 플레이어의 업무표, 미션게이지가 업데이트되고 해당 미션 오브젝트와 플레이어간의 상호작용을 없애는것입니다.
- 요번주차에서는 간단한 미니게임을 구상하였고 해당 미니게임은 미로처럼 구현된 지형에서 빨간색 원에 부딪히지 않고 이동하여 노란색 원에 부딪히면 미션이 완료되는 게임입니다.
- 해당 미니게임의 구성으로는 전체적인 미니게임 패널 안에 하얀색 벽이 있고 좌측의 파란색 네모가 플레이어, 중간에 빨간색 원이 장애물, 우측의 노란색 원은 목표지점입니다. 그리고 해당 패널의 좌측상단에 X표시되어있는 버튼은 해당 미션을 나갈수있는 종료버튼입니다.
- 요번주차에는 플레이어가 미션오브젝트에게 다가가 미션수행버튼을 누르면 미니게임화면이 나오면서 해당 미니게임을 플레이할수있게 구현하였으며 미션 완료 시 이루어지는 업무표,미션게이지의 업데이트 및 해당 미션오브젝트와의 상호작용 해제는 다음주차에 구현할 예정입니다.


------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

VI Earth의 5주차 프로젝트 진행 사항

![KakaoTalk_20201005_210244275](https://user-images.githubusercontent.com/62977669/95077716-ee318b80-074e-11eb-82ea-70094ed1bb1f.jpg)

[실행 영상](https://youtu.be/I4jKNFJMS68)

터치패드를 이용한 캐릭터 이동

- 컴퓨터에서 이용하는 방향키 혹은 w,a,s,d 키가 아닌 스마트폰에서도 
이용이 가능하도록 터치패드를 이용해서 캐릭터 이동이 가능하게 했습니다.


------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

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
