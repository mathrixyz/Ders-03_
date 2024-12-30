using UnityEngine;

public class Debuggingg : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int number1 = 6;
    int number2 = 7;
    int result=13;
    void Start()
    {
        if (result == 14)
            Debug.Log("Sayı 13");
        else
            Debug.Log("Sayı 13 değil");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
