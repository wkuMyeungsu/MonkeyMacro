# MonkeyMacro (4학년 1학기 기업 연계 프로젝트)

## 1. 프로젝트 개요


## 2. 구현 방향

**2.1 프로그램 동작 전반 트리구조**


**📦 폼 : 로그인**   
 ┃   
 ┗ **📦 폼 : 메인**   
 ┃ ┣ 🦾 추적중인 프로그램 표시   
 ┃ ┣ 🦾 추적중인 프로그램의 매크로 키 추가   
 ┃ ┣ **📄 컨트롤 : 홈**   
 ┃ ┃ ┣ 🦾 추적중인 프로그램의 매크로 키 목록 표시   
 ┃ ┃ ┣ 🦾 추적중인 프로그램의 매크로 키 관리 (수정/삭제)    
 ┃ ┃ ┗ ...   
 ┃ ┣ **📄 컨트롤 : 매크로 키 관리**   
 ┃ ┃ ┣ 🦾 저장된 전체 매크로 키 목록 표시   
 ┃ ┃ ┣ 🦾 저장된 전체 매크로 키 목록 관리 (추가/수정/삭제)   
 ┃ ┃ ┗ ...   
 ┃ ┣ **📄 컨트롤 : 환경 설정**   
 ┃ ┃ ┣ 🦾 프로그램 투명도 조절   
 ┃ ┃ ┣ 🦾 프로그램창 맨 상단 고정 ON/OFF   
 ┃ ┃ ┣ 🦾 프로그램 트레이기능 ON/OFF   
 ┃ ┃ ┗ ...   
 

**2.2 상세 폼/컨트롤 구현**
- 1. 폼 : 로그인
     - ID/PW 입력
     - 계정 생성
     - ~~ID/PW 찾기~~
- 2. 폼 : 메인
     - 추적중인 프로그램 폼 상단에 표시 → "tracing : Word"
     - 

**2.3 기술 스택**
- 언어 : C#
- IDE 
