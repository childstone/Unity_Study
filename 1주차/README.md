# Unity_Study

## Rule Tiles

게임의 맵을 만들 때 타일을 하나하나 찍어내지 않고 자동으로 연결되게 하는 것.

타일을 만들 때 타일의 규칙을 설정한다면 (해당 타일이 다른 타일과 어떻게 연결될 것인지) 자동으로 자연스러운 타일을 만든다.

## collider

Collider 컴포넌트는 물리적 충돌을 위해 게임 오브젝트의 모양을 정의합니다. 

캐릭터의 피격 범위로도 사용

플레이어가 더이상 움직이지 못하도록 경계로 사용할 수 있다.

## rigid body

**GameObject**가 물리 제어로 동작하게 합니다.

리지드바디는 힘과 토크를 받아 오브젝트가 사실적으로 움직이도록 해줍니다. 리지드바디가 포함된 모든 게임 오브젝트는 중력의 영향을 받아야 하며 스크립팅을 통해 가해진 힘으로 움직이거나 NVIDIA PhysX 물리 엔진을 통해 다른 오브젝트와 상호 작용해야 합니다.

**body type** 

dynamic으로 하면 물리연산 적용

kinematics로 하면 물리엔진이 적용되지 않고 오로직 transform 으로만 움직임

static 안  움직임

**움직임 구현**

Player라는 Game object에서 rigid body의 body type을 dynamic으로 하여 물리 엔진을 이용해 움직임을 구현

Input.GetAxisRaw() 를 통해 방향 값 추출

public static float **GetAxisRaw**(string **axisName**);

Returns the value of the virtual axis identified by `axisName` with no smoothing filtering applied.

aixsName

`"Vertical"`, `"Horizontal"`, `"Mouse X", "Mouse Y"  등`

return 값 -1~1

dyanmic을 사용할 때  rigid.velocity = new Vector2(h*5,v*5); 와 같이 velocity를 사용하여 플레이어 이동을 구현한다.

**1. Input.GetAxis(string name)**

- 1.0f 부터 1.0f 까지의 범위의 값을 반환한다. 즉, 부드러운 이동이 필요한 경우에 사용된다.

**2. Input.GetAxisRaw(string name)**

- 1, 0, 1 세 가지 값 중 하나가 반환된다. 키보드 값을 눌렀을 때 즉시 반응해야한다면 GetAxisRaw를 사용하면 된다.
