using UnityEngine;
using System.Collections;


    public class Aiming : MonoBehaviour
    {

        public void GetMouseAiming(Vector3 mouse)
        {
			mouse.z = transform.position.z;
            Vector3 mouseDirection = (mouse - transform.position).normalized;
			RotateMono(mouseDirection);
        }

        private void RotateMono(Vector3 mouseDirection){

            transform.rotation = Quaternion.LookRotation (mouseDirection);

        }
    }
