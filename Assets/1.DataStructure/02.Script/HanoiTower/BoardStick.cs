using System.Collections.Generic;
using UnityEngine;

public class BoardStick : MonoBehaviour
{
    public enum StickType { Left, Center, Right }
    public StickType stickType;

    public Stack<GameObject> stickStack = new Stack<GameObject>();

    void OnMouseDown() // Collider만 있으면 동작함
    {
        if (!HanoiTower.isSelected) // 선택이 안된 상태일 때
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
            Debug.Log("선택");
        }
        else // 선택된 상태일 때
        {
            PushDonut(HanoiTower.selectedDonut);
            Debug.Log("이동");
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
                Debug.Log($"현재 넣으려는 도넛은 {pushNumber}이고, 해당 기둥의 제일 위의 도넛은 {peekNumber}입니다.");
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

        stickStack.Push(donut); // Stack에 Gameobject를 넣는 기능
    }

    public GameObject PopDonut()
    {
        GameObject donut = stickStack.Pop(); // Stack에서 GameObject를 꺼내는 기능

        return donut; // 꺼낸 도넛을 반환
    }
}
