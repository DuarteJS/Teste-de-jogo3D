using TMPro;
using Unity.AI.Navigation;
using UnityEngine;

public class Objects : MonoBehaviour
{
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                // Count
                var playerObject = other.GetComponent<PlayerScript1>();

            playerObject.AddObject();


                Destroy(this.gameObject);
            }
        }
    
}
