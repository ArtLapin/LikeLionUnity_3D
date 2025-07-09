using System.Collections.Generic;
using UnityEngine;

public class BoardStick : MonoBehaviour
{
    public enum StickType { Left, Center, Right }
    public StickType stickType;

    public Stack<GameObject> stickStack = new Stack<GameObject>();

    void OnMouseDown() // Collider�� ������ ������
    {
        if (!HanoiTower.isSelected) // ������ �ȵ� ������ ��
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
            Debug.Log("����");
        }
        else // ���õ� ������ ��
        {
            PushDonut(HanoiTower.selectedDonut);
            Debug.Log("�̵�");
        }
    }

    public bool CheckDonut(GameObject donut)
    {
        if (stickStack.Count > 0)
        {
            int pushNumber = donut.GetComponent<Donut>().donutNumber;

            GameObject peekDonut = stickStack.Peek();
            int peekNumber = peekDonut.GetComponent<Donut>().donutNumber;

            if (pushNumber < peekNumber)
            {
                return true;
            }
            else
            {
                Debug.Log($"���� �������� ������ {pushNumber}�̰�, �ش� ����� ���� ���� ������ {peekNumber}�Դϴ�.");
                return false;
            }
        }
        return true;
    }

    public void PushDonut(GameObject donut)
    {
        if (!CheckDonut(donut))
            return;

        HanoiTower.isSelected = false;
        HanoiTower.selectedDonut = null;

        donut.transform.position = transform.position + Vector3.up * 5f;
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        stickStack.Push(donut); // Stack�� Gameobject�� �ִ� ���
    }

    public GameObject PopDonut()
    {
        GameObject donut = stickStack.Pop(); // Stack���� GameObject�� ������ ���

        return donut; // ���� ������ ��ȯ
    }
}
