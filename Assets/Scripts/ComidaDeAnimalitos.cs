using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour

{
    public string codigo;
    public int diasQuevaAQudarse;

    // Start is called before the first frame update
    void Start()
    {
        if (codigo == "G" && diasQuevaAQudarse >3)
        {

        }
        else if (codigo == "PP" && diasQuevaAQudarse > 3)
        {

        }else if (codigo == "PG" && diasQuevaAQudarse > 3)
        {

        }
        else
        {
            Debug.Log("El código y/o dias de estadía no son válidos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
