using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Leccion
{
    public int ID;
    public List<string> lessons;
    public List<string> options;
    public int correctAnswer;
    public int i;
//    public int order;
}

[CreateAssetMenu(fileName = "New Lesson", menuName = "ScriptableObjects/NewLesson", order = i)]

public interface Subject : ScriptableObject
{
    List<Leccion> LeccionList;
}