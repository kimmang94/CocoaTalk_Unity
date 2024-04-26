using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    static Manager s_instace;
    public static Manager Instance
    {
        get
        {
            Init();
            return s_instace;
        }
    }

    void Start()
    {
        Init();
    }

    void Update()
    {

    }

    static void Init()
    {
        if (s_instace == null)
        {
            GameObject obj = GameObject.Find("@Managers");
            if (obj == null)
            {
                obj = new GameObject { name = "@Managers" };
                obj.AddComponent<Manager>();
            }

            DontDestroyOnLoad(obj);
            s_instace = obj.GetComponent<Manager>();
        }
    }
}
