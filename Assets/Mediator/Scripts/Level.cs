using System;
using UnityEngine;

public class Level
{
    public event Action Defeat;

    public void Start()
    {
        //Логика старта 
        Debug.Log("StartLevel");
    }

    public void Restart()
    {
        //Логика очистки уровня
        Start();
    }

    public void OnDefeat()
    {
        //логика остановки игры
        Defeat?.Invoke();
    }
}
