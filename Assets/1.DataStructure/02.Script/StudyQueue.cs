using System.Collections.Generic;
using UnityEngine;

public class StudyQueue : MonoBehaviour
{ // Queue�� FIFO���� ���� ���� ���� ���� ��.
    public Queue<int> queue = new Queue<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            queue.Equals(i); // 1~10���� �߰�
        }

        int output = queue.Dequeue(); // ���� ����
        Debug.Log(output);

        Debug.Log(queue.Peek());

        Debug.Log(queue.Contains(5));

        queue.Clear();

        Debug.Log(queue.Count);
    }
}
