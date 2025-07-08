using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    //ũ�⿡ ���� ������ �˳��� ��Ƽ� �ڵ� Ȯ�� ������ �ڷᱸ��
    private object[] array = new object[3]; // ������Ʈ Ÿ���� �迭

    void Add(object o)
    {
        var temp = new object[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }

        array = temp;
        array[array.Length - 1] = o;
    }

    //public List<int> list1 = new List<int>();
    //public List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
    //public List<int> list3;
    [SerializeField] private List<int> list4 = new List<int>();
    public List<int> list5 = new List<int>();

    public List<int> list1 = new List<int>() { 1,2,3 };

    void Start()
    {
        list1.Add(10); // �������� 10�� �߰�
        //list2.Add(10);
        //list3.Add(10);

        for (int i = 0; i < 10; i++) // 0~9���� ���� list�� �߰�
        {
            list1.Add(i);
        }
        list1.Insert(5, 100); //�ε��� ���� 5��°�� 100�̶�� ���� ����

        //list1.Remove(5); // �� 5�� ����
        //list1.RemoveAt(5); // �ε��� 5���� ����
        //list1.RemoveRange(1, 3); // �ε��� 1~3�� ����
        //list1.Clear(); // ������ ��� ����

        //list1.RemoveAll(x => x == 5); // ���� ����Ʈ���� x>5 ���� ��� ����

        //string str = string.Empty;
        //foreach (var x in list1)
        //{
        //    str += x.ToString() + "/";
        //}

        if (list1.Contains(10)) // ����Ʈ�� 10�̶�� ���� ������ true
        {
            Debug.Log("�� 10�� ����");
        }
        else
            Debug.Log("�� 10�� ����");
    }
}
