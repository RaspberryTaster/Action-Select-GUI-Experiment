using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_Window : MonoBehaviour
{
    public List<Executable_Button> children;

    private void Awake()
    {
        Executable_Button[] children = GetComponentsInChildren<Executable_Button>();
        for (int i = 0; i < children.Length; i++)
		{
            if (this.children.Contains(children[i])) return;
            this.children.Add(children[i]);
		}
        gameObject.SetActive(false);
	}
	public void Move_To_Mouse_Position()
	{
        transform.position = Input.mousePosition;
    }

    public void Initalize(List<IExecutable> executables)
	{
        Clear();

        int iteration_Count = executables.Count;
        if(iteration_Count > children.Count)
		{
            iteration_Count = children.Count;
		}
        for(int i = 0; i < iteration_Count; i++)
		{
            Debug.Log(iteration_Count + " " + i);
            children[i].gameObject.SetActive(true);
            children[i].Initalize(executables[i]);
		}
	}

    public void Clear()
	{
        for (int i = 0; i < children.Count; i++)
        {
            children[i].gameObject.SetActive(false);
        }
    }
}
