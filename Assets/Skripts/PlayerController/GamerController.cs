using UnityEngine;

public class GamerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float speedVertical = 0.5f;
    [SerializeField] private Transform trans;
    public Joystick joystick;
    internal static object instance;

    [SerializeField] private AudioSource audioKatanie;


    public BoxCollider coll;
   public static float ySize = 0.01f;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
      

}


    private void FixedUpdate()
    {


      //  coll.size = new Vector3(ySize, coll.size.y, coll.size.z);



        float moveHorizontal = Input.GetAxis("Horizontal");  //joystick.Horizontal; Input.GetAxis("Horizontal"); //


        Vector3 movement = new Vector3(moveHorizontal, 0, speedVertical);
        rb.AddForce(movement * speed, ForceMode.VelocityChange);

       
       
    }



    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Graund")
    //    {
    //        audioKatanie.Play();
    //    }
    //}




    public void RazmerSharika()
    {


        // obj.GetComponent<Moneti>().enabled = false;

       
            trans.localScale = new Vector3(90f * Time.timeScale, 90f * Time.timeScale, 90f * Time.timeScale); 
       
    }


    public void RazmerSharikaUp()
    {

        trans.localScale = new Vector3(190f, 190f, 190f);
        
    }














   

}
