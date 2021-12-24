### 클라이언트
1. api 주소로 serviceHelp 생성
2. serviceHelp의 메서드를 이용
	- 메서드에서 비동기, 제너릭을 사용함 => VO 사용가능

BaseForm/BaseFormSample.cs에 Sample 코드 추가 중

### 서버
1. Models 폴더에 클래스를 생성 (DAC) -> DAC 코드 작성
2. Controllers 폴더 오른쪽 클릭 -> 생성 -> 컨트롤러 -> Web API -> [Web API 2 컨트롤러 - 비어 있음] 클릭
3. Controller 이름 지정
	- SampleController 라고 이름 지으면 api 주소는 /api/Sample
	- Controller 단어는 지우면 안 됨
4. 컨트롤러 코드 작성 (SampleController 참고)
5. 솔루션 빌드
6. commit - push
7. https://github.com/enterpro75/GDC8-Team2/actions 에 가서 서버배포 작업 진행 상태를 볼 수 있음 (평균 2분 소요)

azure 서버 대신 로컬에서 테스트 하고 싶으면 APSWinForm 프로젝트의 App.config - ApiAddress를 로컬 주소로 바꾸고
테스트 할 때 PSServer와 APSWinForm을 같이 켜면 됨


### 샘플 실행

postman으로 http://team2aps.azurewebsites.net/api/Sample/List (POST) 호출

WinForm 실행 후 상단 메뉴의 샘플 클릭

![sample](https://user-images.githubusercontent.com/75368967/147208276-884b21be-d642-47b3-ba7e-69b065823ce2.png)
