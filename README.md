# TopDownGame


v 표시가 완료됨을 의미함
 
### 과제 개요


1. Unity 를 이용해 ZEP과 같은 시점의 게임을 모방해 만드는 과제입니다.
2. 타일맵을 이용해 배경을 꾸밉니다.
3. 기본 UI 들을 활용해 적용하는 연습이 포함됩니다.

###시연영상

https://gifmaker.me/video-to-gif/viewimage/20240513-13-1xjrU44gTWPzSEon-aqtEEa-HNET

### 모든 요구사항 적용



### 요구사항

- **필수요구사항**
    - 1. 캐릭터 만들기 v

        
        - 외부 그림파일을 추가하여 2D 캐릭터를 추가합니다. v
            - 유니티 입문 학습 과정에서 사용한 이미지 v
            - AssetStore 에서 다운 받은 이미지 등
            - 예제에 사용된 캐릭터 에셋 - [Link](https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747)
    - 2. 캐릭터 이동 v

        
        - 키보드 A/W/S/D 를 이용하여 캐릭터가 움직입니다. v
        - 캐릭터는 마우스 방향을 바라봅니다. (좌/우) v
    - 3. 방 만들기 v

        
        - 타일맵을 이용하여 맵을 만듭니다.
            - 유니티 입문 학습 과정에서 사용한 이미지 v
            - AssetStore 에서 다운 받은 이미지 등 v
            - 예제에 사용된 배경 에셋 - [Link](https://assetstore.unity.com/packages/2d/environments/rogue-fantasy-castle-164725)
        - 콜라이더를 이용해 벽을 넘어가지 못합니다.
    - 4. 카메라 따라가기 v

        
        - 카메라는 움직임에 따라 캐릭터를 따라갑니다. v
    - 5. 캐릭터 애니메이션 추가 v

        
        - 실행하면 캐릭터가 애니메이션을 반복합니다. v
        - 가만히 서있을때와 움직일때 애니메이션을 구분하지는 않아도 됩니다. v
    - 6. 이름 입력 시스템 v

        
        - 실행시 글자를 입력을 받을 수 있는 UI 를 만듭니다. v
            - 2~10 글자 사이 v
                - 아니라면 Join 버튼이 눌리지 않습니다. v
        - Join 을 누르면 맵으로 이동하여 캐릭터 위에 이름표가 나타납니다. v
            - 이름표는 캐릭터가 움직이면 따라 다닙니다. v
    - 7. 캐릭터 선택 시스템 v

        
        - 맵으로 들어가기 전 캐릭터가 표시되는 UI 가 나타납니다. v
        - 캐릭터를 클릭하면 캐릭터 선택 팝업이 나타납니다. v
        - 캐릭터를 선택하면 팝업이 닫힙니다. v
        - 선택했던 캐릭터가 표시됩니다. v

     
- **선택요구사항**
    - 1. 시간 표시 (난이도 - ★★☆☆☆) v

        
        - 왼쪽 상단에 현재 시간을 표시하는 UI 를 만듭니다. v
    - 2. 인게임 이름 바꾸기 (난이도 - ★★★☆☆) v

        
        - 하단 메뉴 오른쪽에 이름 바꾸기 버튼을 만듭니다. v
            - 입력하면 캐릭터 위쪽 이름과 오른쪽 메뉴 이름이 변경됩니다. v
    - 3. 참석 인원 UI (난이도 - ★★★☆☆)

        
        - UI 는 캐릭터가 움직여도 화면에 고정됩니다. v
        - 화면 오른쪽에 현재 맵에 있는 사람의 목록을 보여줍니다. v
            - 예제에서는 2명 있습니다.
                - 염예찬 튜터
                - 학생 - Chad
            - NPC 를 더 추가한다면 이 목록에 이름이 보이도록 해보세요. v
            - x 버튼을 누르면 UI 가 꺼집니다. v
        - 화면 하단에는 파란색 UI 가 있습니다. v
            - 참석인원 아래에 버튼을 부르면 목록이 다시 생깁니다. v
    - 4. 인게임 캐릭터 선택 (난이도 - ★★★★☆) v

        
        - 하단 메뉴 오른쪽에 캐릭터 선택 버튼을 만듭니다. v
            - 캐릭터 선택시 게임화면의 캐릭터가 바로 반영 됩니다. v
    - 5. NPC 대화 (난이도 - ★★★★★)

        
        - 튜터에게 가까이 가면 대화 걸기 버튼이 생깁니다. v
        - 튜터에게 멀어지면 다시 버튼이 사라집니다. v
        - 버튼을 누른다면 대화가 시작됩니다. v

선택 요구사항을 하다보면 UI 를 만들어야하는 경우가 있습니다.
