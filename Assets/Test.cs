using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public class Boss
    {
        private int hp = 100;
        private int power = 25;
        private int mp = 53;

        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            this.hp -= damage;
        }

        public void Magic()
        {
            if(this.mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + mp);
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }

    }
    void Start()
    {
        int[] array = {1,2,3,4,5};
        int i;

        for (i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss lastboss = new Boss();

        lastboss.Magic();

        for (i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
