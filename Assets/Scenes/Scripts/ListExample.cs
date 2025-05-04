using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax;
    private List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        numeroMax = (numeroMax <= 0) ? Random.Range(3, 21) : numeroMax;
        FillList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FillList()
    {
        for (int i = 0; i <= numeroMax; i++)
        {
            InsertNumber(i);
            PrintList();
        }
    }

    void InsertNumber(int number)
    {
        int position = number % 3;
        if (position == 0)
        {
            InsertAtStart(number);
        }
        else if (position == 1)
        {
            InsertAtEnd(number);
        }
        else if (position == 2)
        {
            InsertAtMiddle(number);
        }
    }

    void InsertAtStart(int number)
    {
        numbers.Insert(0, number);
    }

    void InsertAtEnd(int number)
    {
        numbers.Add(number);
    }

    void InsertAtMiddle(int number)
    {
        int middleIndex = numbers.Count / 2;
        numbers.Insert(middleIndex, number);
    }

    void PrintList()
    {
        Debug.Log("Contenuto lista: " + ListToString(numbers));
    }

    string ListToString(List<int> list)
    {
        return "[" + string.Join(", ", list) + "]";
    }
}
