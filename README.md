# Knight-of-Dungeon-SampleCode
포트폴피오 샘플 코드입니다

Unity 기반 Dungeon RPG 게임에서 자주 사용되는 핵심 Gameplay 시스템을  
**모듈형 구조로 설계한 샘플 코드 모음**입니다.  
각 기능은 독립적으로 사용 가능하며, 실제 프로젝트에 바로 적용할 수 있도록 구성하였습니다.

## 🎮 주요 기능 (Features)

| 시스템 | 설명 | 폴더 경로 |
|---|---|---|
| 인벤토리 시스템 | ScriptableObject 기반 아이템 데이터 & UI Drag&Drop | `/Inventory` |
| 강화 시스템 | 확률 기반 장비 강화 + 연출 | `/Upgrade` |
| 몬스터 FSM AI | Idle / Chase / Attack / Die 상태 기반 AI | `/EnemyFSM` |
| 아이템 시스템 | 아이템별 아이템명,타입,프리팹 통합 데이터 구조 | `/Inventory` |
| 플레이어 시점 고정 |가까운 적의 거리를 계산하여 시점 고정| `/Player` |
| 오브젝트 폴링 | 몬스터 리스폰 및 리스폰 위치 조정 | `/Pooling` |

## 🛠️ 사용 기술 (Tech Stack)

| 구분 | 내용 |
|---|---|
| Engine | Unity 2022.3 LTS |
| Language | C# |
| Pattern / Architecture | FSM, State Pattern, Singleton, Strategy, Object Pooling |
| 연출 / 그래픽 | Cinemachine, Shader Graph |
| 협업 | Git / GitHub |

---

## 🌟 설계 의도 (Why I Built It This Way)

- 시스템을 **분리 설계**하여 필요한 기능만 프로젝트에 선택적으로 추가 가능
- 밸런스 변경이나 데이터 조정을 위해 **ScriptableObject 기반 데이터 구조** 채택
- 플레이어/적/카메라/이펙트가 상호 작용할 때 **병목과 중복을 줄이는 구조**를 지향
- 실전 프로젝트에서 바로 재사용할 수 있는 **프로덕션 수준 패턴 적용**
- ScriptableObject를 사용한 이유는 밸런스 조정 시 데이터 드리븐 방식으로
프로젝트 전체에 영향을 최소화하기 위함입니다.

---


### 🎥 시연 영상

(https://www.youtube.com/watch?v=X-CGv4ttQig)
1:25 ~ 2:02 인벤토리 시스템 & 장비 강화
2:55 ~ 3:10 미니맵 ui
3:12 ~ 3:27  몬스터 FSM AI & 레벨업
3:50 ~ 4:20  플레이어 시점 고정
5:54 ~ 6:50 보스 컷신 및 보스 패턴

