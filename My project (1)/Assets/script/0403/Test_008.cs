using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{

    private int hp = 100;                                                            //hp를 선언한후 100의 값을 입력
    private int Power = 50;                                                          //power를 선언한 후 50의 값을 입력

    public void Attack()
    {
        Debug.Log(this.Power + "데미지를 입혔다.");                                  //this는 Player 클래스를 이야기한다.
    }

    public void Damage(int damage)                                                   //Damage 함수는 int 형태로 받은 데미지 인수를 받는다.
    {
        this.hp -= damage;
        Debug.Log(damage + " 데미지를 입었다.");
    }

    public int GetHp()
    {
        return this.hp;
    }
}
    public class Test_008 : MonoBehaviour
    {

        Player player_01 = new Player();                                             //위에 만든 플레이어 클래스를 선언한다. (전역에 사용하기 위해서)
        Player player_02 = new Player();                                             //위에 만든 플레이어 클래스를 선언한다. (전역에 사용하기 위해서)
        public Text player01HP;                                                      //플레이어 HP를 보여주는 UI 선언
        public Text player02HP;                                                      //플레이어 HP를 보여주는 UI 선언

        void Start()
        {

            player_01.Attack();
            player_01.Damage(30);

        }
        // Update is called once per frame
        void Update()
        {
        player01HP.text = "Player01HP : " + player_01.GetHp().ToString(); //GetHp() 함수를 호출하고 ToString으로 문자열로 변환
        player02HP.text = "Player02HP : " + player_02.GetHp().ToString(); //GetHp() 함수를 호출하고 ToString으로 문자열로 변환

       


        if (Input.GetMouseButtonDown(0))             //왼쪽 마우스를 눌렀을때
            {
                player_01.Damage(1);                     //player_01의 객체의 함수 Damage
            }

            if (Input.GetMouseButtonDown(1))
            {
                player_02.Damage(1);
            }
        }
    }

