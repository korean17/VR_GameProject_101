using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{

    private int hp = 100;                                                            //hp�� �������� 100�� ���� �Է�
    private int Power = 50;                                                          //power�� ������ �� 50�� ���� �Է�

    public void Attack()
    {
        Debug.Log(this.Power + "�������� ������.");                                  //this�� Player Ŭ������ �̾߱��Ѵ�.
    }

    public void Damage(int damage)                                                   //Damage �Լ��� int ���·� ���� ������ �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + " �������� �Ծ���.");
    }

    public int GetHp()
    {
        return this.hp;
    }
}
    public class Test_008 : MonoBehaviour
    {

        Player player_01 = new Player();                                             //���� ���� �÷��̾� Ŭ������ �����Ѵ�. (������ ����ϱ� ���ؼ�)
        Player player_02 = new Player();                                             //���� ���� �÷��̾� Ŭ������ �����Ѵ�. (������ ����ϱ� ���ؼ�)
        public Text player01HP;                                                      //�÷��̾� HP�� �����ִ� UI ����
        public Text player02HP;                                                      //�÷��̾� HP�� �����ִ� UI ����

        void Start()
        {

            player_01.Attack();
            player_01.Damage(30);

        }
        // Update is called once per frame
        void Update()
        {
        player01HP.text = "Player01HP : " + player_01.GetHp().ToString(); //GetHp() �Լ��� ȣ���ϰ� ToString���� ���ڿ��� ��ȯ
        player02HP.text = "Player02HP : " + player_02.GetHp().ToString(); //GetHp() �Լ��� ȣ���ϰ� ToString���� ���ڿ��� ��ȯ

       


        if (Input.GetMouseButtonDown(0))             //���� ���콺�� ��������
            {
                player_01.Damage(1);                     //player_01�� ��ü�� �Լ� Damage
            }

            if (Input.GetMouseButtonDown(1))
            {
                player_02.Damage(1);
            }
        }
    }

