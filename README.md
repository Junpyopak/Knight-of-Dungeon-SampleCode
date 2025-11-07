# Knight-of-Dungeon-SampleCode
포트폴피오 샘플 코드입니다

Unity 기반 Dungeon RPG 게임에서 자주 사용되는 핵심 Gameplay 시스템을  
**모듈형 구조로 설계한 샘플 코드 모음**입니다.  
각 기능은 독립적으로 사용 가능하며, 실제 프로젝트에 바로 적용할 수 있도록 구성하였습니다.

## 🎮 주요 기능 (Features)

| 시스템 | 설명 | 폴더 경로 |
|---|---|---|
| 인벤토리 시스템 | ScriptableObject 기반 아이템 데이터 & UI Drag&Drop | `/InventorySystem` |
| 강화 시스템 | 확률 기반 장비 강화 + 연출 | `/EquipmentUpgradeSystem` |
| 몬스터 FSM AI | Idle / Chase / Attack / Die 상태 기반 AI | `/EnemyFSM` |
| 아이템 드랍 시스템 | 몬스터별 드랍 테이블 기반 랜덤 드랍 처리 | `/DropAndLootSystem` |
| Slash 이펙트 | Mesh Trail + Shader 기반 휘둘림 궤적 | `/WeaponSlashEffect` |
| 보스 컷씬 카메라 | Cinemachine Virtual Camera 전환 연출 | `/CinemachineBossCamera` |

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

---

## 📷 데모 / 영상
