using System.Collections.Generic;
using UnityEngine;

public class StudyQueue : MonoBehaviour
{ // Queue는 FIFO구조 먼저 넣은 값을 먼저 뺌.
    public Queue<int> queue = new Queue<int>();

    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            queue.Equals(i); // 1~10까지 추가
        }

        int output = queue.Dequeue(); // 값을 뽑음
        Debug.Log(output);

        Debug.Log(queue.Peek());

        Debug.Log(queue.Contains(5));

        queue.Clear();

        Debug.Log(queue.Count);
    }
}
