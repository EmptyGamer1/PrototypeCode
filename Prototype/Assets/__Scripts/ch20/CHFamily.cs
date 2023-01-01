using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHFamily : MonoBehaviour
{
    public CHHuman Husband;
    public CHHuman Wife;

    private void Start()
    {
        Husband = new CHHuman();
        Wife = new CHHuman();

        Husband.Name = "Tom";
        Wife.Name = "Lora";

        //Мы, я и моя жена женаты
        Husband.Partner = Wife;
        Wife.Partner = Husband;

        Husband.Name = "Jeremi Gibson";
        Wife.Name = "Sara Rizold";

        Debug.Log(Husband.Partner.Name);
    }
}
