using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawSignature : MonoBehaviour
{
    public GameObject blackSquare;
    public float Timer = 0;
    public GameObject Contract;
    public GameObject whiteSquare;
    public GameObject button;
    public bool newLine = false;
    public int lineSpawnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && transform.localPosition.x > 28.682f && transform.localPosition.y < -11.918f && transform.localPosition.x < 31.197f && transform.localPosition.y > -12.709f)
         {
           Timer += Time.deltaTime;
        
            if (Timer < 3)
            {
                if (lineSpawnCount == 0)
                {
                    GameObject draw = Instantiate(blackSquare, transform.position, Quaternion.identity);
                    draw.transform.SetParent(Contract.transform);
                    lineSpawnCount++;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            Contract.BroadcastMessage("stop_Drawing");
            lineSpawnCount = 0;
           
        }
        if (Timer > 3)
        {
            button.SendMessage("contract_Signed");
            Destroy(Contract);
           whiteSquare.SetActive(false); 
            Destroy(this.gameObject);

        }
    }
    
}
