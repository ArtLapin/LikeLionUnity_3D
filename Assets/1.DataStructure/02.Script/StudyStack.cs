using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();
    public int[] array = new int[3] {1,2,3};
    public int[] array2;
    public List<int> list1 = new List<int>();
    // 나중에 추가된 데이터가 가장 먼저 나오는 구조 LIFO
    private void Start()
    {
        //for (int i = 1; i <= 10; i++)
        //{
        //    stack.Push(i); // 1~10까지 값을 stack에 추가
        //}
        //Debug.Log(stack.Pop());

        //Debug.Log(stack.Peek()); // 그 다음에 뽑힐 대상 확인

        stack = new Stack<int>(array);
        list1 = stack.ToList();
        array2 = stack.ToArray();
        

    }
}
