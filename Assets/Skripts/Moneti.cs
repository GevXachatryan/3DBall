using UnityEngine;
using UnityEngine.UI;



public class Moneti : MonoBehaviour
{
    public static int coins = 0;
    public Text textCoins;
    public Text textLevL;
    public Rigidbody rb;


    public GameObject pause;
    public GameObject maniu;












  // public  BoxCollider coll;

  //static float ySize = 0.1f;


  //  static float x;




  //  private void FixedUpdate()
  //  {
       
  //      coll.size = new Vector3(ySize, coll.size.y, coll.size.z);
  //      x = coll.size.x;
  //  }





    


    public void OnTriggerEnter(Collider other)
    {


       

        if (other.gameObject.tag == "Coin" && GamerController.ySize == 0.01f)
        {
            coins++;
            Destroy(other.gameObject);
            textCoins.text = coins.ToString();

            if(coins == 20)
            {
                pause.SetActive(false);
                maniu.SetActive(true);
            }
        }
    }


}
