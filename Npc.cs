using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Npc : MonoBehaviour
{
    // Start is called before the first frame update
     //Declaramos nivel npc
    public int level=1;
    // Actualizamos la vida del npc
    public int health=30;
    public float speed =1.5f;

    void Start()
    {
        
         level += health;
         // Imprimimos el numero de vidas en la consola
         print("Numero Vidas:" + health);
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 newPosition = transform.position;
    newPosition.z += 
speed * Time.deltaTime; 
    transform.position = newPosition;
    }

}
