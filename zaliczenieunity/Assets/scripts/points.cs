using UnityEngine;

public class Item : MonoBehaviour
{
    // statyczne wartosci dla punktow
    private int dkoscpoints = 10;
    private int mkoscpoints = 1;
    //odwolanie do skrytpu zliczajacego punkty
    public scoremanager points;
    // OnTriggerEnter2D is called when the Collider2D other enters the trigger
    public void OnTriggerEnter2D(Collider2D col)
    {
         if (col.gameObject.CompareTag("Player"))
        {
            if (gameObject.tag == "mkosc")
            {
                points.AddPoint(mkoscpoints);
                Destroy(gameObject);
            }
            else if(gameObject.tag == "dkosc")
            {
                points.AddPoint(dkoscpoints);
                Destroy(gameObject);
            }
        }
    }
}