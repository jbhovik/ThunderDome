using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class CameraFollow : MonoBehaviour
    {
		Transform target;
		float distance = 10.0f;
		float height = 10.0f;

		void LateUpdate(){
			if (!target)
				return;

			Vector3 forward = target.TransformDirection (Vector3.forward);
			Vector3 targetPosition = target.position;
			Vector3 temp = transform.position;
			transform.position = targetPosition - forward * distance;
			temp.y += height;
			transform.position = temp;
			transform.LookAt (target);
		}
    }
}