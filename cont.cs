using UnityEngine;
using System.Collections;

public class cont : MonoBehaviour
{
		CharacterController controller;
		Vector3 moveDirection;
		int speed = 1;
		int gravity = 10;				
		int speedRotate = 2;

		void Awake ()
		{
				controller = GetComponent<CharacterController> ();
		//jiiuiuiuiu


		}
	

		void Update ()
		{

				
					
				//}
				
				//moveDirection.y -= gravity * Time.deltaTime;		
				controller.Move (moveDirection * Time.deltaTime);		
				transform.Rotate (0, 0.3f, 0, Space.World);
		}


		
}