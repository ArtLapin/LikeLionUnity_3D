using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack = new Stack<int>();
    public int[] array = new int[3] {1,2,3};
    public int[] array2;
    public List<int> list1 = new List<int>();
    // ���߿� �߰��� �����Ͱ� ���� ���� ������ ���� LIFO
    private void Start()
    {
        //for (int i = 1; i <= 10; i++)
        //{
        //    stack.Push(i); // 1~10���� ���� stack�� �߰�
        //}
        //Debug.Log(stack.Pop());

        //Debug.Log(stack.Peek()); // �� ������ ���� ��� Ȯ��

        stack = new Stack<int>(array);
        list1 = stack.ToList();
        array2 = stack.ToArray();
        

    }
}
