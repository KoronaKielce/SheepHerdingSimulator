using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public  GameObject instance;
    public int timesMade = 0;
    void Awake()
    {
       

        if (instance == null)
        {
            instance = this.gameObject;
            DontDestroyOnLoad(gameObject);
            timesMade = 1;
        }
        else if (instance == this && timesMade == 1)
        {           
                Destroy(gameObject);          
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
