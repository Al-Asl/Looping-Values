using UnityEngine;
using System.Collections;

public class LoopExample : MonoBehaviour
{

    void Start()
    {
        LoopFloat angle = new LoopFloat(0, 0, 360);
        angle += 30f;
        Debug.Log(angle);
        angle -= 60f;
        Debug.Log(angle);
        angle += 1380f;
        Debug.Log(angle);
        angle.SetValue(30f);
        Debug.Log(angle.Delta(330f));

        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        LoopInt indexer = new LoopInt(0, 0, numbers.Length);

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(numbers[indexer++]);
        }

    }
}
