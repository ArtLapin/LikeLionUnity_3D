using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    //크기에 따라 공간을 넉넉히 잡아서 자동 확장 가능한 자료구조
    private object[] array = new object[3]; // 오브젝트 타입의 배열

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
        list1.Add(10); // 마지막에 10을 추가
        //list2.Add(10);
        //list3.Add(10);

        for (int i = 0; i < 10; i++) // 0~9까지 값을 list에 추가
        {
            list1.Add(i);
        }
        list1.Insert(5, 100); //인덱서 기준 5번째에 100이라는 값을 삽입

        //list1.Remove(5); // 값 5를 제거
        //list1.RemoveAt(5); // 인덱스 5번을 제거
        //list1.RemoveRange(1, 3); // 인덱스 1~3번 제거
        //list1.Clear(); // 데이터 모두 제거

        //list1.RemoveAll(x => x == 5); // 현재 리스트에서 x>5 값은 모두 제거

        //string str = string.Empty;
        //foreach (var x in list1)
        //{
        //    str += x.ToString() + "/";
        //}

        if (list1.Contains(10)) // 리스트에 10이라는 값이 있으면 true
        {
            Debug.Log("값 10이 존재");
        }
        else
            Debug.Log("값 10이 없음");
    }
}
